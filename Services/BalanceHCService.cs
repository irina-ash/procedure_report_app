using procedure_report_app.Data;
using procedure_report_app.Models;
using Microsoft.EntityFrameworkCore;
using LinqToDB;

namespace procedure_report_app.Services
{
    public class BalanceHCService
    {
        private static ApplicationDbContext _dbContext;
        private const string guidProductOil = "B3EFC82F-7AB7-4220-8212-9FB49583736A";
        private const string guidProductDG = "4C16568A-7E38-478C-9AAD-41CDA710C598";
        private string[] sproductcomponentGuids = {guidProductOil, guidProductDG};
        private string[] categories = {"A","B1","B2","C1","C2"};
        private int yearBalance = 2016;

        public BalanceHCService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        private float GetOilValue(Guid guid, string[] categories, string category, float[] values)
        {
            float value = 0;
            if (guid.ToString() == guidProductOil && categories.Contains(category)) 
            {
                value = values.Sum();
            }
            return value;
        }


        private float GetDGValue(Guid guid, string[] categories, string category, float[] values)
        {
            float value = 0;
            if (guid.ToString() == guidProductDG && categories.Contains(category)) 
            {
                value = values.Sum();
            }
            return value;
        }

        public IQueryable<ReserveReportItem> GetTmpListByPlace(int paramYear, string paramSub, string paramCompany, string paramDeposit) 
        {
            /* по месторождению */
            var reserves1 = from b in _dbContext.BalanceHCSet
                            join bd in _dbContext.BalanceHCDepositSet
                            on b.GUID equals bd.GUID_BalanceHC
                            select new {
                                bGUID = b.GUID,
                                bYearBalance = b.YearBalance,
                                bGUIDCompany = b.GUID_Company,
                                bdGUID = bd.GUID,
                                bdGUIDsSub = bd.GUID_sSub,
                                bdGUIDObject = bd.GUID_Objects_Deposit == null ? bd.GUID : bd.GUID_Objects_Deposit,
                                bdGUIDObjectsDeposit = bd.GUID_Objects_Deposit,
                            };

            var reserves2 = from r1 in reserves1.DefaultIfEmpty()
                            join ss in _dbContext.SSubSet
                            on r1.bdGUIDsSub equals ss.GUID
                            select r1;

            var reserves3 = from r2 in reserves2.DefaultIfEmpty()
                            join bz in _dbContext.BalanceHCZalezhSet
                            on r2.bdGUID equals bz.GUID_BalanceHC_Deposit
                            select new {
                                bzGUID = bz.GUID, 
                                bz.GUID_License, 
                                r2
                            };

            var reserves4 = from r3 in reserves3.DefaultIfEmpty()
                            join l in _dbContext.LicenseSet
                            on r3.GUID_License equals l.GUID
                            select r3;             

            var reserves5 = from r4 in reserves4.DefaultIfEmpty()
                            join kz in _dbContext.GeolObjectKategZalezhSet
                            on r4.bzGUID equals kz.GUID_BalanceHC_Zalezh   
                            select new { 
                                r4,
                                kzGUID = kz.GUID, 
                                kzCategory = kz.category
                            };      

            var reserves6 = from r5 in reserves5.DefaultIfEmpty()
                            join zc in _dbContext.BalanceHCZapasCategorySet
                            on r5.kzGUID equals zc.GUID_GeolObject_KategZalezh
                            select new {
                                r5,
                                zcGUIDsProductComponent = zc.GUID_sProductComponent,
                                zcZapasTekYearGeo = zc.zapastekyeargeo,
                                zcZapasTekYearIzvl = zc.zapastekyearizvl,
                                zcZapasTekYearEconomic = zc.ZapasTekYearEconomic,
                                zcDobicha = zc.dobicha,
                                zcDobNacSNachEndYear = zc.DobNacSNachEndYear,
                                zcPotNacSNachEndYear = zc.PotNacSNachEndYear,
                                zcPoteri = zc.poteri,
                            };  

            var BalanceHCDepositSetGrouped = _dbContext.BalanceHCDepositSet
                                            .GroupBy(x => new {x.GUID_BalanceHC, x.GUID_sSub, x.GUID_Objects_Deposit, x.GUID},
                                                    (key, group) => new { 
                                                            key.GUID_BalanceHC, 
                                                            key.GUID_sSub,
                                                            key.GUID_Objects_Deposit,
                                                            key.GUID,
                                                            Items = group.ToList() 
                                                        })
                                            .Select(bd2 => new {
                                                        GUID_BalanceHC = bd2.GUID_BalanceHC,
                                                        GUID_sSub = bd2.GUID_sSub,
                                                        GUID_Object = bd2.GUID_Objects_Deposit == null ? bd2.GUID : bd2.GUID_Objects_Deposit,
                                                        GUID_ObjectForName = bd2.Items.Max(o => o.GUID),
                                                    });                           

            var reserves7 = from r6 in reserves6.DefaultIfEmpty()
                            join gofn in BalanceHCDepositSetGrouped
                            on new {GUID = r6.r5.r4.r2.bGUID, GUIDsSub = r6.r5.r4.r2.bdGUIDsSub, GUIDObjects = r6.r5.r4.r2.bdGUIDObjectsDeposit} equals 
                               new {GUID = gofn.GUID_BalanceHC, GUIDsSub = gofn.GUID_sSub, GUIDObjects = gofn.GUID_Object}
                            select new {
                                gofnGUIDObjectForName = gofn.GUID_ObjectForName, r6
                            };

            var reservesFinal = reserves7.DefaultIfEmpty()
                                .Join(_dbContext.BalanceHCDepositSet,
                                    r7 => r7.gofnGUIDObjectForName,
                                    bd2 => bd2.GUID,
                                    (r7, bd2) => new {r7, bd2}
                                )
                                .Where(w => w.r7.r6.r5.r4.r2.bYearBalance == paramYear && w.r7.r6.r5.r4.r2.bYearBalance >= yearBalance)
                                .Where(w => categories.Contains(w.r7.r6.r5.kzCategory))
                                .Where(w => sproductcomponentGuids.Contains(w.r7.r6.zcGUIDsProductComponent.ToString()))
                                .GroupBy(x => new {
                                    x.r7.r6.r5.r4.r2.bGUIDCompany, 
                                    x.r7.r6.r5.r4.r2.bdGUIDsSub,
                                    x.r7.r6.r5.r4.r2.bdGUIDObjectsDeposit,
                                    x.r7.r6.r5.r4.r2.bdGUIDObject,
                                    x.r7.r6.r5.r4.r2.bdGUID,
                                    x.r7.gofnGUIDObjectForName,
                                }, (key, group) => new { 
                                                            key.bGUIDCompany, 
                                                            key.bdGUIDsSub,
                                                            key.bdGUIDObjectsDeposit,
                                                            key.bdGUIDObject,
                                                            key.bdGUID,
                                                            key.gofnGUIDObjectForName,
                                                            Items = group.ToList() 
                                                        })
                                .Select(res => new {
                                    rowtype = 3,
                                    guid_company = res.bGUIDCompany,
                                    GUID_Sub = res.bdGUIDsSub,
                                    GUID_Object = res.bdGUIDObject,
                                    GUID_ObjectForName = res.gofnGUIDObjectForName,
                                    /*OilFirstYearGeoAB1C1 = (float)0,
                                    OilFirstYearGeoB2C2 = (float)0,
                                    OilFirstYearExtAB1C1 = (float)0,
                                    OilFirstYearExtB2C2 = (float)0,
                                    OilEndYearGeoAB1 = (float)0,
                                    OilEndYearGeoB2 = (float)0,
                                    OilEndYearExtAB1 = (float)0,
                                    OilEndearEcoAB1 = (float)0,
                                    OilEndYearExtB2 = (float)0,
                                    OilEndearEcoB2 = (float)0,
                                    OilEndYearGeoC1 = (float)0,
                                    OilEndearGeoC2 = (float)0,
                                    OilEndYearExtC1 = (float)0,
                                    OilEndYearExtC2 = (float)0,
                                    OilProduction = (float)0,
                                    OilEndYearCumulativeProduction = (float)0,
                                    DGEndYearExtAB1C1 = (float)0,
                                    DGEndYearExtB2C2 = (float)0,
                                    DGEndYearExtAB1 = (float)0,
                                    DGEndYearExtB2 = (float)0,
                                    DGEndYearExtC1 = (float)0,
                                    DGEndYearExtC2 = (float)0,
                                    DGProduction = (float)0,
                                    DGEndYearCumulativeProduction = (float)0,*/
                                });     

            return (IQueryable<ReserveReportItem>)reservesFinal;
        }
    }
}