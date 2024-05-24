using Microsoft.EntityFrameworkCore;
using Website_clothing.IRepositories;
using Website_clothing.IServices;
using Website_clothing.Models;

namespace Website_clothing.Services
{
    public class SanPhamService : ISanPhamService
    {
        private readonly ICRUDRepository<SanPham> _repository;
        private readonly Website_clothing_DbContext _context;

        public SanPhamService(ICRUDRepository<SanPham> repository, Website_clothing_DbContext context)
        {
            _repository = repository;
            _context = context;
        }
        public async Task Create(SanPham sanPham)
        {
            await _repository.Create(sanPham);
        }

        public async Task Delete(Guid id)
        {
            await _repository.Delete(id);
        }

        public async Task<List<SanPham>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<List<SanPham>> ListSanPhamOrderByName()
        {
            return await _context.SanPhams.AsNoTracking().OrderBy(sp => sp.Ten).ToListAsync();
        }

        public async Task<SanPham> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public async Task Update(SanPham sanPham)
        {
            await _repository.Update(sanPham);
        }
    }
}
