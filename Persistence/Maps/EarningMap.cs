using Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Maps
{
    public class EarningMap : IEntityTypeConfiguration<Earning>
    {
        public void Configure(EntityTypeBuilder<Earning> builder)
        {
            builder.ToTable("Earnings");
            builder.HasKey(x => x.IdEarning);
        }
    }
}
