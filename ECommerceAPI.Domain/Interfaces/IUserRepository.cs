using ECommerceAPI.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Domain.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<int> TotalUserCountAsync();
        Task<User?> GetUserByEmailAsync(string Email);
        Task<IEnumerable<User>> GetUsersByRoleAsync(string Role);


    }
}
