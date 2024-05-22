namespace Website_clothing.Models
{
    public class GiamGia
    {
        public Guid ID { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public float GiaTri { get; set; }
        public DateTime NgayApDung { get; set; }
        public DateTime NgayHetHan { get; set; }
        public int SoLuong { get; set; }
        public string MoTa { get; set; }
        public bool TrangThai { get; set; }
        public virtual ICollection<CTSanPham>? CTSanPhams { get; set; }
    }
}
