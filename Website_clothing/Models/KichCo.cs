namespace Website_clothing.Models
{
    public class KichCo
    {
        public Guid ID { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public bool TrangThai { get; set; }
        public ICollection<CTSanPham>? cTSanPhams { get; set; }
    }
}
