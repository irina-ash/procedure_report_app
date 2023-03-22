using procedure_report_app.Data;
using procedure_report_app.Models;
using Microsoft.EntityFrameworkCore;
using LinqToDB;

namespace procedure_report_app.Services
{
    public class BalanceHCService
    {
        private static ApplicationDbContext _dbContext;

        public BalanceHCService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        int year = 2020;

        /* по месторождению */
        var reserves = _dbContext.BalanceHCSet.Join(_dbContext.BalanceHCDepositSet, 
            b => b.GUID,
            bd => bd.GUID_BalanceHC,
            (b, bd) => b.GUID == bd.GUID_BalanceHC      
        ).toList();
    }
}