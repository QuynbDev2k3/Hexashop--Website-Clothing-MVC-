using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website_clothing.Models;

namespace Website_clothing.Configurations;

public class HangConfiguration : IEntityTypeConfiguration<Hang>
{
    public void Configure(EntityTypeBuilder<Hang> builder)
    {
        builder.HasKey(p => p.ID);
        builder.Property(p => p.Ma).HasColumnType("varchar(15)").IsRequired();
        builder.Property(p => p.Ten).HasColumnType("nvarchar(100)").IsRequired();
        builder.Property(p => p.TrangThai).HasColumnType("int").IsRequired();
    }
}