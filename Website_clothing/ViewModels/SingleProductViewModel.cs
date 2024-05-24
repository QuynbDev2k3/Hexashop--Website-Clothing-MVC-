using Website_clothing.Models;

namespace Website_clothing.ViewModels
{
    public class SingleProductViewModel
    {
        public SanPham sanPham { get; set; }
        public List<CTSanPham> cTSanPham { get; set; }
        public List<MauSac> MauSacs { get; set; }
        public List<KichCo> KichCos { get; set; }
        public List<ChatLieu> ChatLieus { get; set; }
        public List<Hang> hangs { get; set; }
    }
}
