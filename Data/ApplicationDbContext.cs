using Microsoft.EntityFrameworkCore;
using procedure_report_app.Models;

namespace procedure_report_app.Data 
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<EXT_BalanceHC_Deposit> BalanceHCDepositSet { get; set; }
        public DbSet<EXT_BalanceHC_Zalezh> BalanceHCZalezhSet { get; set; }
        public DbSet<EXT_BalanceHC_ZapasCategory> BalanceHCZapasCategorySet { get; set; }
        public DbSet<EXT_BalanceHC> BalanceHCSet { get; set; }
        public DbSet<EXT_Companys> CompanysSet { get; set; }
        public DbSet<EXT_GeolObject_KategZalezh> GeolObjectKategZalezhSet { get; set; }
        public DbSet<EXT_License> LicenseSet { get; set; }
        public DbSet<EXT_sSub> SSubSet { get; set; }

         public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
    }
}