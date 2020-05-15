using Business.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Maps;

namespace Persistence
{
    public class MainContext : DbContext
    {
        public DbSet<Debt> Debts { get; set; }
        public DbSet<DebtDetail> DebtDetails { get; set; }
        public DbSet<Earning> Earnings { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Spending> Spending { get; set; }

        public MainContext(DbContextOptions<MainContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DebtMap());
            modelBuilder.ApplyConfiguration(new DebtDetailMap());
            modelBuilder.ApplyConfiguration(new EarningMap());
            modelBuilder.ApplyConfiguration(new GoalMap());
            modelBuilder.ApplyConfiguration(new SpendingMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
