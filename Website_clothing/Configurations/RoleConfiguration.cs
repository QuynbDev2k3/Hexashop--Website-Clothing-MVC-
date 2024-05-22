using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website_clothing.Models;

namespace Website_clothing.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(r => r.ID);
            builder.Property(r => r.Ma).HasColumnType("varchar(15)").IsRequired();
            builder.Property(r => r.Ten).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(r => r.TrangThai).HasColumnType("bit");

        }
    }
}
