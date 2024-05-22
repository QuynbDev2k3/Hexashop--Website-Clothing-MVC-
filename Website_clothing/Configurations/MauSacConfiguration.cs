using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website_clothing.Models;

namespace Website_clothing.Configurations;

public class MauSacConfiguration : IEntityTypeConfiguration<MauSac>
{
    public void Configure(EntityTypeBuilder<MauSac> builder)
    {
        builder.HasKey(p => p.ID);
        builder.Property(p => p.Ma).HasColumnType("varchar(15)").IsRequired();
        builder.Property(p => p.TenMauSac).HasColumnType("nvarchar(50)").IsRequired();
        builder.Property(p => p.TrangThai).HasColumnType("bit").IsRequired();
    }
}