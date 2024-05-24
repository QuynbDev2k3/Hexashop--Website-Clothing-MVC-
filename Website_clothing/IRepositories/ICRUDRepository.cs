namespace Website_clothing.IRepositories;

public interface ICRUDRepository<T> where T : class
{
    Task<List<T>> GetAll();
    Task<T> GetById(Guid id);
    Task Create(T entity);
    Task Update(T entity);
    Task Delete(Guid id);
}