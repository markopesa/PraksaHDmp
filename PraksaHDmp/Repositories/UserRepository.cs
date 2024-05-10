using Microsoft.EntityFrameworkCore;
using PraksaHDmp.Contracts;
using PraksaHDmp.Data;

namespace PraksaHDmp.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly ApplicationDbContext context;
        public UserRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
        public async Task<List<User>> GetActiveUsersAsync()
        {
            return await context.User.Where(u => u.Active).ToListAsync();
        }
        public async Task<List<User>> GetInactiveUsersAsync()
        {
            return await context.User.Where(u => !u.Active).ToListAsync();
        }

    }
}
