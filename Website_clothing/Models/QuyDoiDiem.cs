namespace Website_clothing.Models
{
    public class QuyDoiDiem
    {
        public Guid ID { get; set; }
        public string Ma { get; set; }
        public float TiLeTichDiem { get; set; }
        public bool TrangThai { get; set; }
        public virtual ICollection<LichSuTichDiem>? LichSuTichDiems { get; set; }
    }
}
