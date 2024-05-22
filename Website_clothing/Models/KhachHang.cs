namespace Website_clothing.Models
{
    public class KhachHang
    {
        public Guid ID { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public float Diem { get; set; }
        public bool TrangThai { get; set; }
        public ICollection<LichSuMuaHang>? lichSuMuaHangs { get; set; }
        public virtual GioHang? GioHang { get; set; }
        public ICollection<HoaDon>? hoaDons { get; set; }
        public ICollection<LichSuTichDiem>? lichSuTichDiems { get; set; }
    }
}
