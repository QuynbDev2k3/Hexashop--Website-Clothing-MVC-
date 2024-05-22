namespace Website_clothing.Models
{
    public class LichSuMuaHang
    {
        public Guid ID { get; set; }
        public Guid? IDHoaDon { get; set; }
        public Guid? IDKhachHang { get; set; }
        public string Ma { get; set; }
        public bool TrangThai { get; set; }
        public virtual KhachHang? KhachHang { get; set; }
        public virtual HoaDon? HoaDon { get; set; }
    }
}
