namespace Website_clothing.Models
{
    public class CTGioHang
    {
        public Guid ID { get; set; }
        public float TongTien { get; set; }
        public int SoLuong { get; set; }
        public GioHang? GioHang { get; set; }
        public CTSanPham? CTSanPhams { get; set; }
        public Guid? GioHangID { get; set; }
        public Guid? IdCTSanPham { get; set; }

    }
}
