using System.ComponentModel.DataAnnotations;
namespace Website_clothing.Models
{
    public class LichSuTichDiem
    {
        [Key]
        public Guid ID { get; set; }
        public Guid IDKhachHang { get; set; }
        public Guid IDQuyDoiDiem { get; set; }
        public Guid? IDHoaDon { get; set; }
        public string Ma { get; set; }
        public float Diem { get; set; }
        public bool TrangThai { get; set; }
        public virtual KhachHang? KhachHang { get; set; }
        public virtual QuyDoiDiem? QuyDoiDiem { get; set; }
        public virtual HoaDon? HoaDon { get; set; }
    }
}
