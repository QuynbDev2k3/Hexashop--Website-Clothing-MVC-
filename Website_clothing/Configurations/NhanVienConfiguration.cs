﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website_clothing.Models;

namespace Website_clothing.Configurations;

public class NhanVienConfiguration : IEntityTypeConfiguration<NhanVien>
{
    public void Configure(EntityTypeBuilder<NhanVien> builder)
    {
        builder.HasKey(p => p.ID);
        builder.Property(p => p.Ma).HasColumnType("varchar(100)").IsRequired();
        builder.Property(p => p.Ten).HasColumnType("nvarchar(50)").IsRequired();
        builder.Property(p => p.SDT).HasColumnType("varchar(15)").IsRequired();
        builder.Property(p => p.Email).HasColumnType("varchar(50)").IsRequired();
        builder.Property(p => p.DiaChi).HasColumnType("nvarchar(100)").IsRequired();
        builder.Property(p => p.MatKhau).HasColumnType("varchar(50)").IsRequired();
        builder.Property(p => p.TrangThai).HasColumnType("bit").IsRequired();
        builder.HasOne(p => p.Role).WithMany(p => p.NhanViens).HasForeignKey(p => p.IDRole);
    }
}