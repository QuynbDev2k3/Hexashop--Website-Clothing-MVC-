using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website_clothing.Models;

namespace Website_clothing.Configurations
{
    internal class KhachHangConfiguration : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.HasKey(k => k.ID);
            builder.Property(k => k.Ma).HasColumnType("varchar(100)").IsRequired();
            builder.Property(k => k.Ten).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(k => k.GioiTinh).HasColumnType("bit").IsRequired();
            builder.Property(k => k.NgaySinh).HasColumnType("datetime").IsRequired();
            builder.Property(k => k.SDT).HasColumnType("char(15)").IsRequired();
            builder.Property(k => k.MatKhau).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(k => k.Email).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(k => k.Diem).HasColumnType("float").IsRequired();
            builder.Property(k => k.DiaChi).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(k => k.TrangThai).HasColumnType("bit").IsRequired();
        }
    }
}
