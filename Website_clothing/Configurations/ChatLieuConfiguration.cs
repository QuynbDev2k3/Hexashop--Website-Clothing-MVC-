using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website_clothing.Models;

namespace Website_clothing.Configurations
{
    public class ChatLieuConfiguration : IEntityTypeConfiguration<ChatLieu>
    {
        public void Configure(EntityTypeBuilder<ChatLieu> builder)
        {
            builder.HasKey(r => r.ID);
            builder.Property(r => r.Ma).HasColumnType("varchar(15)").IsRequired();
            builder.Property(r => r.Name).HasColumnType("varchar(50)").IsRequired();
            builder.Property(r => r.TrangThai).HasColumnType("bit").IsRequired();
        }
    }
}
