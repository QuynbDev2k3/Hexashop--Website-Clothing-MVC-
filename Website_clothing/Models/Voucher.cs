namespace Website_clothing.Models
{
    public class Voucher
    {
        public Guid ID { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string DieuKien { get; set; }
        public float GiaTri { get; set; }
        public DateTime NgayApDung { get; set; }
        public DateTime NgayHetHan { get; set; }
        public int SoLuong { get; set; }
        public string MoTa { get; set; }
        public bool trangthai { get; set; }
        public virtual ICollection<CTSanPham>? CTSanPhams { get; set; }
        public virtual ICollection<HoaDon>? HoaDons { get; set; }


    }
}
