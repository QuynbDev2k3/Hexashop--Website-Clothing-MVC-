namespace Website_clothing.Models
{
    public class ChatLieu
    {
        public Guid ID { get; set; }
        public string Ma { get; set; }
        public string Name { get; set; }
        public bool TrangThai { get; set; }
        public virtual ICollection<CTSanPham>? CTSanPhams { get; set; }
    }
}
