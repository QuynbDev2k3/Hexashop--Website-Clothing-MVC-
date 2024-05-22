using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website_clothing.Models;

namespace Website_clothing.Configurations
{
    public class DanhMucSanPhamConfiguration : IEntityTypeConfiguration<DanhMucSanPham>
    {
        public void Configure(EntityTypeBuilder<DanhMucSanPham> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.Ma).HasColumnType("varchar(15)").IsRequired();
            builder.Property(p => p.Ten).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.TrangThai).HasColumnType("bit").IsRequired();
        }
    }
}
