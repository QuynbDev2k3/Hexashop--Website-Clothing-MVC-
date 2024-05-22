using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website_clothing.Models;

namespace Website_clothing.Configurations;

public class SanPhamConfiguration : IEntityTypeConfiguration<SanPham>
{
    public void Configure(EntityTypeBuilder<SanPham> builder)
    {
        builder.HasKey(p => p.ID);
        builder.Property(p => p.Ma).HasColumnType("varchar(max)").IsRequired();
        builder.Property(p => p.Anh).HasColumnType("varchar(max)").IsRequired();
        builder.Property(p => p.Ten).HasColumnType("nvarchar(50)").IsRequired();
        builder.Property(p => p.Gia).HasColumnType("float").IsRequired();
        builder.Property(p => p.TrangThai).HasColumnType("bit").IsRequired();
        builder.HasOne(c => c.DanhMucSanPham).WithMany(c => c.SanPhams).HasForeignKey(c => c.IDDanhMucSanPham);
    }
}