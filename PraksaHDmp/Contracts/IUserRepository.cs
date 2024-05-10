using Microsoft.EntityFrameworkCore;
using PraksaHDmp.Data;

namespace PraksaHDmp.Contracts
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<List<User>> GetActiveUsersAsync();
        Task<List<User>> GetInactiveUsersAsync();
      
    }
}
