using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website_clothing.Models;

namespace Website_clothing.Configurations
{
    internal class GiamGiaConfiguration : IEntityTypeConfiguration<GiamGia>
    {
        public void Configure(EntityTypeBuilder<GiamGia> builder)
        {
            builder.HasKey(g => g.ID);
            builder.Property(p => p.Ma).HasColumnType("varchar(15)").IsRequired();
            builder.Property(p => p.Ten).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(p => p.GiaTri).HasColumnType("float").IsRequired();
            builder.Property(p => p.NgayApDung).HasColumnType("datetime").IsRequired();
            builder.Property(p => p.NgayHetHan).HasColumnType("datetime").IsRequired();
            builder.Property(p => p.SoLuong).HasColumnType("int").IsRequired();
            builder.Property(p => p.MoTa).HasColumnType("nvarchar(500)").IsRequired();
            builder.Property(p => p.TrangThai).HasColumnType("bit").IsRequired();

        }
    }
}
