using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website_clothing.Models;

namespace Website_clothing.Configurations
{
    public class CTHoaDonConfiguration : IEntityTypeConfiguration<CTHoaDon>
    {
        public void Configure(EntityTypeBuilder<CTHoaDon> builder)
        {
            builder.HasKey(r => r.ID);
            builder.Property(r => r.DonGia).HasColumnType("float").IsRequired();
            builder.Property(r => r.SoLuong).HasColumnType("int").IsRequired();
            builder.Property(r => r.TrangThai).HasColumnType("bit").IsRequired();
            builder.HasOne(c => c.HoaDon).WithMany(c => c.CTHoaDons).HasForeignKey(c => c.IdHoaDon);
        }
    }
}
