using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Website_clothing.Models
{
    public class Website_clothing_DbContext : DbContext
    {
        public Website_clothing_DbContext() { }

        public Website_clothing_DbContext(DbContextOptions<Website_clothing_DbContext> options) : base(options) { }

        public DbSet<MauSac> mauSacs { get; set; }
        public DbSet<LichSuMuaHang> lichSuMuaHangs { get; set; }
        public DbSet<DoiTra> doiTras { get; set; }
        public DbSet<KichCo> KichCos { get; set; }
        public DbSet<CTGioHang> CTGioHangs { get; set; }
        public DbSet<GioHang> GioHangs { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ChatLieu> chatlieus { get; set; }
        public DbSet<Voucher> vouchers { get; set; }
        public DbSet<CTHoaDon> CtHoadons { get; set; }
        public DbSet<HoaDon> hoadons { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<CTSanPham> CtSanPhams { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<Hang> Hangs { get; set; }
        public DbSet<GiamGia> GiamGias { get; set; }
        public DbSet<DanhMucSanPham> DanhMucSanPhams { get; set; }
        public DbSet<DanhGia> DanhGias { get; set; }
        public DbSet<LichSuTichDiem> LichSuTichDiems { get; set; }
        public DbSet<QuyDoiDiem> QuyDoiDiems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=QUY\\SQLEXPRESS;Initial Catalog = Website_Clothing; Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
