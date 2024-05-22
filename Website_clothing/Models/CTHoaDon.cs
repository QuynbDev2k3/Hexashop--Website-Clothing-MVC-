namespace Website_clothing.Models
{
    public class CTHoaDon
    {
        public Guid ID { get; set; }
        //FK
        public Guid IdHoaDon { get; set; }
        public Guid IdCTSP { get; set; }
        public float DonGia { get; set; }
        public int SoLuong { get; set; }
        public bool TrangThai { get; set; }
        public virtual HoaDon? HoaDon { get; set; }

    }
}
