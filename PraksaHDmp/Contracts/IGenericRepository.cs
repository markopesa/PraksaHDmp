namespace PraksaHDmp.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAdync(int id);
        Task<List<T>> GetAllAsync();
        Task<bool> Exists(int id);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);
        Task AddAsync(T entity);
    }
}
