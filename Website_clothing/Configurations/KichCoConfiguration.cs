using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website_clothing.Models;

namespace Website_clothing.Configurations
{
    public class KichCoConfiguration : IEntityTypeConfiguration<KichCo>
    {
        public void Configure(EntityTypeBuilder<KichCo> builder)
        {
            builder.HasKey(k => k.ID);
            builder.Property(k => k.Ma).HasColumnType("varchar(15)").IsRequired();
            builder.Property(k => k.Ten).HasColumnType("nvarchar(5)").IsRequired();
            builder.Property(k => k.TrangThai).HasColumnType("bit").IsRequired();
        }
    }
}
