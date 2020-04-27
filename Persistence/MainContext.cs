using Business.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Maps;

namespace Persistence
{
    public class MainContext : DbContext
    {
        public DbSet<Debt> Debts { get; set; }
        public DbSet<DebtDetail> DebtDetails { get; set; }

        public MainContext(DbContextOptions<MainContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DebtMap());
            modelBuilder.ApplyConfiguration(new DebtDetailMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
