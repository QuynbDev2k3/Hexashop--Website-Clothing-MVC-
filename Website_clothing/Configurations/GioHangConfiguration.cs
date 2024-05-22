using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website_clothing.Models;

namespace Website_clothing.Configurations
{
    public class GioHangConfiguration : IEntityTypeConfiguration<GioHang>
    {
        public void Configure(EntityTypeBuilder<GioHang> builder)
        {
            builder.HasKey(g => g.ID);
            builder.Property(g => g.NgayTao).HasColumnType("datetime").IsRequired();
            builder.Property(g => g.TrangThai).HasColumnType("bit").IsRequired();
            builder.HasOne(g => g.KhachHang).WithOne(g => g.GioHang).HasForeignKey<KhachHang>(p => p.ID);
        }
    }
}
