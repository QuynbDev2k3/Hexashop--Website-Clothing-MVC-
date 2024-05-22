using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website_clothing.Models;

namespace Website_clothing.Configurations;

public class LichSuMuaHangConfiguraton : IEntityTypeConfiguration<LichSuMuaHang>
{
    public void Configure(EntityTypeBuilder<LichSuMuaHang> builder)
    {
        builder.HasKey(p => p.ID);
        builder.Property(p => p.Ma).HasColumnType("varchar(15)").IsRequired();
        builder.Property(p => p.TrangThai).HasColumnType("int").IsRequired();
        builder.HasOne(p => p.KhachHang).WithMany(p => p.lichSuMuaHangs).HasForeignKey(p => p.IDKhachHang);
        builder.HasOne(p => p.HoaDon).WithOne(p => p.LichSuMuaHang).HasForeignKey<LichSuMuaHang>(p => p.IDHoaDon);

    }
}