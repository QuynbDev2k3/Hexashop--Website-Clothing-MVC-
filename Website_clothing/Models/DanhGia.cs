namespace Website_clothing.Models
{
    public class DanhGia
    {
        public Guid ID { get; set; }
        public string Ma { get; set; }
        public string BinhLuan { get; set; }
        public int Sao { get; set; }
        public DateTime NgayDanhGia { get; set; }
        public bool TrangThai { get; set; }
        public virtual CTSanPham? CTSanPhams { get; set; }
    }
}
