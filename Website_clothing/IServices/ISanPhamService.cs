using Website_clothing.Models;

namespace Website_clothing.IServices
{
    public interface ISanPhamService
    {
        Task<List<SanPham>> GetAll();
        Task<List<SanPham>> ListSanPhamOrderByName();
        Task<SanPham> GetById(Guid id);
        Task Create(SanPham sanPham);
        Task Update(SanPham sanPham);
        Task Delete(Guid id);
    }
}
