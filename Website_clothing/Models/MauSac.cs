namespace Website_clothing.Models
{
    public class MauSac
    {
        public Guid ID { get; set; }
        public string Ma { get; set; }
        public string TenMauSac { get; set; }
        public bool TrangThai { get; set; }
        public virtual ICollection<CTSanPham>? cTSanPhams { get; set; }
    }
}
