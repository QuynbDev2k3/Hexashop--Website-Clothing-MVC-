using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website_clothing.Models;

namespace Website_clothing.Configurations
{
    public class CTGioHangConfiguration : IEntityTypeConfiguration<CTGioHang>
    {
        public void Configure(EntityTypeBuilder<CTGioHang> builder)
        {
            builder.HasKey(c => c.ID);
            builder.Property(c => c.TongTien).HasColumnType("float").IsRequired();
            builder.Property(c => c.SoLuong).HasColumnType("int").IsRequired();
            builder.HasOne(c => c.GioHang).WithMany(c => c.cTGioHangs).HasForeignKey(c => c.GioHangID);
            builder.HasOne(c => c.CTSanPhams).WithMany(c => c.CTGioHang).HasForeignKey(c => c.IdCTSanPham);
        }
    }
}
