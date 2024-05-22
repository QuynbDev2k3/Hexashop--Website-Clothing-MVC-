namespace Website_clothing.Models
{
    public class DanhMucSanPham
    {
        public Guid ID { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public bool TrangThai { get; set; }
        public virtual ICollection<SanPham>? SanPhams { get; set; }
    }
}
