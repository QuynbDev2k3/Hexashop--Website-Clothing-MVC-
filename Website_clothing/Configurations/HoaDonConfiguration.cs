using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website_clothing.Models;

namespace Website_clothing.Configurations
{
    public class HoaDonConfiguration : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.HasKey(r => r.ID);
            builder.Property(r => r.Ma).HasColumnType("varchar(max)").IsRequired();
            builder.Property(r => r.TienShip).HasColumnType("float").IsRequired();
            builder.Property(r => r.NgayTao).HasColumnType("datetime").IsRequired();
            builder.Property(r => r.TenNgNhan).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(r => r.SDT).HasColumnType("char(15)").IsRequired();
            builder.Property(r => r.Email).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(r => r.PTThanhToan).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(r => r.TongTien).HasColumnType("float").IsRequired();
            builder.Property(r => r.DiaChi).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(r => r.GhiChu).HasColumnType("nvarchar(500)").IsRequired();
            builder.Property(r => r.NgayNhanHang).HasColumnType("datetime").IsRequired();
            builder.Property(r => r.NgayThanhToan).HasColumnType("datetime").IsRequired();
            builder.Property(r => r.TrangThai).HasColumnType("bit").IsRequired();
            builder.HasMany(p => p.Vouchers).WithMany(p => p.HoaDons);
            builder.HasOne(p => p.DoiTra).WithOne(p => p.HoaDon).HasForeignKey<DoiTra>(p => p.IdHoaDon);
            // builder.HasOne(p => p.LichSuMuaHang).WithOne(p => p.HoaDon).HasForeignKey<LichSuMuaHang>(p => p.IdHoaDon);
            builder.HasOne(p => p.NhanVien).WithMany(p => p.HoaDons).HasForeignKey(p => p.IDNhanVien);
            builder.HasOne(p => p.KhachHang).WithMany(p => p.hoaDons).HasForeignKey(p => p.IDKhachHang);
        }
    }
}
