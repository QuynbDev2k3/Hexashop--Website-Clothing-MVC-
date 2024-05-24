using Microsoft.EntityFrameworkCore;
using Website_clothing.IRepositories;
using Website_clothing.Models;

namespace Website_clothing.Repositories;

public class CRUDRepository<T> : ICRUDRepository<T> where T : class
{
    private readonly Website_clothing_DbContext _context;
    private DbSet<T> dbSet;

    public CRUDRepository(Website_clothing_DbContext context)
    {
        this._context = context;
        this.dbSet = context.Set<T>();
    }

    public async Task<List<T>> GetAll()
    {
        return await dbSet.ToListAsync();
    }

    public async Task<T> GetById(Guid id)
    {
        return await dbSet.FindAsync(id);
    }

    public async Task Create(T entity)
    {
        await dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Update(T entity)
    {
        dbSet.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        var entity = await dbSet.FindAsync(id);
        dbSet.Remove(entity);
        await _context.SaveChangesAsync();
    }
}