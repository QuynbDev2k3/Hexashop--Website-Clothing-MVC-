using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website_clothing.Models;

namespace Website_clothing.Configurations;

public class LichSuTichDiemConfiguration : IEntityTypeConfiguration<LichSuTichDiem>
{
    public void Configure(EntityTypeBuilder<LichSuTichDiem> builder)
    {
        builder.HasKey(k => k.ID);
        builder.Property(k => k.Ma).HasColumnType("varchar(15)").IsRequired();
        builder.Property(k => k.Diem).HasColumnType("float").IsRequired();
        builder.Property(k => k.TrangThai).HasColumnType("bit").IsRequired();
        builder.HasOne(p => p.KhachHang).WithMany(p => p.lichSuTichDiems).HasForeignKey(p => p.IDKhachHang);
        builder.HasOne(p => p.QuyDoiDiem).WithMany(p => p.LichSuTichDiems).HasForeignKey(p => p.IDQuyDoiDiem);
        builder.HasOne(p => p.HoaDon).WithOne(p => p.LichSuTichDiem).HasForeignKey<LichSuTichDiem>(p => p.IDHoaDon);
    }
}