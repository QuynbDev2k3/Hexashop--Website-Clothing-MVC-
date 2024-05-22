namespace Website_clothing.Models
{
    public class GioHang
    {
        public Guid ID { get; set; }
        public DateTime NgayTao { get; set; }
        public virtual KhachHang? KhachHang { get; set; }
        public bool TrangThai { get; set; }
        public virtual ICollection<CTGioHang>? cTGioHangs { get; set; }
    }
}
