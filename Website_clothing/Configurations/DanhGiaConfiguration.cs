using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website_clothing.Models;

namespace Website_clothing.Configurations;

public class DanhGiaConfiguration : IEntityTypeConfiguration<DanhGia>
{
    public void Configure(EntityTypeBuilder<DanhGia> builder)
    {
        builder.HasKey(r => r.ID);
        builder.Property(r => r.Ma).HasColumnType("varchar(15)").IsRequired();
        builder.Property(r => r.BinhLuan).HasColumnType("nvarchar(500)").IsRequired();
        builder.Property(r => r.Sao).HasColumnType("int").IsRequired();
        builder.Property(r => r.NgayDanhGia).HasColumnType("datetime").IsRequired();
        builder.Property(r => r.TrangThai).HasColumnType("bit").IsRequired();
        builder.HasOne(c => c.CTSanPhams).WithMany(c => c.DanhGias).HasForeignKey(c => c.ID);
    }
}