using Microsoft.EntityFrameworkCore;
using Website_clothing.IRepositories;
using Website_clothing.IServices;
using Website_clothing.Models;

namespace Website_clothing.Services;

public class HangService : IHangService
{
    private readonly ICRUDRepository<Hang> repository;
    private readonly Website_clothing_DbContext _context;

    public HangService(ICRUDRepository<Hang> repository, Website_clothing_DbContext _context)
    {
        this.repository = repository;
        this._context = _context;
    }

    public async Task<IEnumerable<Hang>> GetAll()
    {
        return await repository.GetAll();
    }

    public async Task<Hang> GetById(Guid id)
    {
        return await repository.GetById(id);
    }

    public async Task Create(string ten, bool trangthai)
    {
        Hang hang = new Hang()
        {
            ID = Guid.NewGuid(),
            Ten = ten,
            TrangThai = trangthai,
        };
        await repository.Create(hang);
    }

    public async Task Update(Guid id, string ten, bool trangthai)
    {
        var hang = await _context.Hangs.SingleOrDefaultAsync(p => p.ID == id);
        if (hang != null)
        {
            hang.Ten = ten;
            hang.TrangThai = trangthai;
        }
        await repository.Update(hang);
    }

    public async Task Delete(Guid id)
    {
        await repository.Delete(id);
    }
}