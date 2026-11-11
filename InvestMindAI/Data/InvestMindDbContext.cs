
using InvestMindAI.Models;
using Microsoft.EntityFrameworkCore;

namespace InvestMindAI.Data
{
    public class InvestMindDbContext : DbContext
    {
        public InvestMindDbContext(DbContextOptions<InvestMindDbContext> options)
            : base(options)
        {
        }

        public DbSet<Expense> Expenses => Set<Expense>();

        public DbSet<FinancialSettings> FinancialSettings => Set<FinancialSettings>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FinancialSettings>()
                .HasData(new FinancialSettings
                {
                    Id = 1,
                    StocksValue = 0,
                    EtfValue = 0,
                    CashValue = 0,
                    OtherAssetsValue = 0,
                    MonthlyBudget = 0
                });
        }
    }
}
