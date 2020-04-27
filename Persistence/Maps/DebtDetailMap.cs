using Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Maps
{
    public class DebtDetailMap : IEntityTypeConfiguration<DebtDetail>
    {
        public void Configure(EntityTypeBuilder<DebtDetail> builder)
        {
            builder.ToTable("DebtDetails");
            builder.HasKey(x => x.IdDebtDetail);
        }
    }
}
