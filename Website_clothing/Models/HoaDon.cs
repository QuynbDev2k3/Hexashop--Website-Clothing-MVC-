namespace Website_clothing.Models
{
    public class HoaDon
    {
        public Guid ID { get; set; }
        //foreign key
        public Guid IDCTHoaDon { get; set; }
        public Guid IDVoucher { get; set; }
        public Guid IDNhanVien { get; set; }
        public Guid IDKhachHang { get; set; }
        public string Ma { get; set; }
        public float TienShip { get; set; }
        public DateTime NgayTao { get; set; }
        public string TenNgNhan { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string PTThanhToan { get; set; }
        public float TongTien { get; set; }
        public string DiaChi { get; set; }
        public string GhiChu { get; set; }
        public DateTime NgayNhanHang { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public bool TrangThai { get; set; }
        public virtual ICollection<CTHoaDon>? CTHoaDons { get; set; }
        public virtual ICollection<Voucher>? Vouchers { get; set; }
        public virtual NhanVien? NhanVien { get; set; }
        public virtual DoiTra? DoiTra { get; set; }
        public virtual KhachHang? KhachHang { get; set; }
        public virtual LichSuMuaHang? LichSuMuaHang { get; set; }
        public virtual LichSuTichDiem? LichSuTichDiem { get; set; }
    }
}
