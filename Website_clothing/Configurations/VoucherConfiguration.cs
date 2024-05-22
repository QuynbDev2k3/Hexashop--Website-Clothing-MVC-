using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website_clothing.Models;

namespace Website_clothing.Configurations
{
    public class VoucherConfiguration : IEntityTypeConfiguration<Voucher>
    {
        public void Configure(EntityTypeBuilder<Voucher> builder)
        {
            builder.HasKey(r => r.ID);
            builder.Property(r => r.Ma).HasColumnType("varchar(15)").IsRequired();
            builder.Property(r => r.Ten).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(r => r.DieuKien).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(r => r.GiaTri).HasColumnType("float").IsRequired();
            builder.Property(r => r.NgayApDung).HasColumnType("datetime").IsRequired();
            builder.Property(r => r.NgayHetHan).HasColumnType("datetime").IsRequired();
            builder.Property(r => r.SoLuong).HasColumnType("int").IsRequired();
            builder.Property(r => r.MoTa).HasColumnType("varchar(500)").IsRequired();
            builder.Property(r => r.trangthai).HasColumnType("bit").IsRequired();

        }
    }


}
