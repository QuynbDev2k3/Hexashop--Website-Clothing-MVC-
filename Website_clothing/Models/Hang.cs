namespace Website_clothing.Models;

public class Hang
{
    public Guid ID { get; set; }
    public string Ma { get; set; }
    public string Ten { get; set; }
    public bool TrangThai { get; set; }
    public virtual ICollection<CTSanPham>? ctsanphams { get; set; }
}