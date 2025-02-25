﻿namespace Website_clothing.Models;

public class CTSanPham
{
    public Guid ID { get; set; }
    public Guid IDSanPham { get; set; }
    public Guid IDVoucher { get; set; }
    public Guid IDMauSac { get; set; }
    public Guid IDKichCo { get; set; }
    public Guid IDChatLieu { get; set; }
    public Guid IDGiamGia { get; set; }
    public Guid IDHang { get; set; }
    public Guid? IDDanhGia { get; set; }
    public float GiaBan { get; set; }
    public int SoLuong { get; set; }
    public int Age { get; set; }
    public DateTime NgayTao { get; set; }
    public string MoTa { get; set; }
    public string Ma { get; set; }
    public bool TrangThai { get; set; }
    public virtual Hang? hang { get; set; }
    public virtual SanPham? sanpham { get; set; }
    public virtual ICollection<Voucher>? vouchers { get; set; }
    public virtual ICollection<MauSac>? MauSacs { get; set; }
    public virtual ICollection<KichCo>? kichCos { get; set; }
    public virtual ChatLieu? ChatLieu { get; set; }
    public virtual GiamGia? GiamGia { get; set; }
    public virtual ICollection<CTGioHang>? CTGioHang { get; set; }
    public virtual ICollection<DanhGia>? DanhGias { get; set; }
}