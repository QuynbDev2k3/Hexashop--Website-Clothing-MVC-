using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website_clothing.Models;

namespace Website_clothing.Configurations;

public class DoiTraConfiguration : IEntityTypeConfiguration<DoiTra>
{
    public void Configure(EntityTypeBuilder<DoiTra> builder)
    {
        builder.HasKey(p => p.ID);
        builder.Property(p => p.Ma).HasColumnType("varchar(15)").IsRequired();
        builder.Property(p => p.NgayDoiTra).HasColumnType("datetime").IsRequired();
        builder.Property(p => p.LyDo).HasColumnType("nvarchar(100)").IsRequired();
        builder.Property(p => p.HanDoi).HasColumnType("datetime").IsRequired();
        builder.Property(p => p.TrangThai).HasColumnType("bit").IsRequired();
        builder.HasOne(p => p.SanPham).WithMany(p => p.DoiTras).HasForeignKey(p => p.IdSanPham);
        builder.HasOne(p => p.HoaDon).WithOne(p => p.DoiTra).HasForeignKey<DoiTra>(p => p.IdHoaDon);
    }
}