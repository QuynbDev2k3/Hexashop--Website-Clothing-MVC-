namespace Website_clothing.Models
{
    public class DoiTra
    {
        public Guid ID { get; set; }
        public string Ma { get; set; }
        public DateTime NgayDoiTra { get; set; }
        public string LyDo { get; set; }
        public DateTime HanDoi { get; set; }
        public bool TrangThai { get; set; }
        public Guid IdHoaDon { get; set; }
        public Guid IdSanPham { get; set; }
        public virtual SanPham? SanPham { get; set; }
        public virtual HoaDon? HoaDon { get; set; }

    }
}
