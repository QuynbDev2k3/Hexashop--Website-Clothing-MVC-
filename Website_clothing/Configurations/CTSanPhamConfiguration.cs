﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website_clothing.Models;

namespace Website_clothing.Configurations;

public class CTSanPhamConfiguration : IEntityTypeConfiguration<CTSanPham>
{
    public void Configure(EntityTypeBuilder<CTSanPham> builder)
    {
        builder.HasKey(p => p.ID);
        builder.Property(p => p.Ma).HasColumnType("varchar(max)").IsRequired();
        builder.Property(p => p.GiaBan).HasColumnType("float").IsRequired();
        builder.Property(p => p.SoLuong).HasColumnType("int").IsRequired();
        builder.Property(p => p.Age).HasColumnType("int").IsRequired();
        builder.Property(p => p.NgayTao).HasColumnType("datetime").IsRequired();
        builder.Property(p => p.MoTa).HasColumnType("nvarchar(max)").IsRequired();
        builder.Property(p => p.TrangThai).HasColumnType("int").IsRequired();
        builder.HasOne(p => p.ChatLieu).WithMany(p => p.CTSanPhams).HasForeignKey(p => p.IDChatLieu);
        builder.HasOne(p => p.hang).WithMany(p => p.ctsanphams).HasForeignKey(p => p.IDHang);
        builder.HasMany(p => p.vouchers).WithMany(p => p.CTSanPhams);
        builder.HasMany(p => p.MauSacs).WithMany(p => p.cTSanPhams);
        builder.HasMany(p => p.kichCos).WithMany(p => p.cTSanPhams);
        builder.HasOne(p => p.ChatLieu).WithMany(p => p.CTSanPhams).HasForeignKey(p => p.IDChatLieu);
        builder.HasOne(p => p.GiamGia).WithMany(p => p.CTSanPhams).HasForeignKey(p => p.IDGiamGia);
        builder.HasOne(p => p.sanpham).WithOne(p => p.ctsanpham).HasForeignKey<CTSanPham>(p => p.IDSanPham);
    }
}