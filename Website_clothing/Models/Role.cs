namespace Website_clothing.Models
{
    public class Role
    {
        public Guid ID { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public bool TrangThai { get; set; }
        public virtual ICollection<NhanVien>? NhanViens { get; set; }
    }
}
