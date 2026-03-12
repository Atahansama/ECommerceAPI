using ECommerceAPI.Core.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Core.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDTO>> GetAllUsersAsync();
        Task<UserDTO?> GetUserByIdAsync(int id);
        Task<UserDTO?> GetUserByEmailAsync(string email);
        Task<int> GetTotalUserCountAsync();
        Task<IEnumerable<UserDTO>> GetUsersByRoleAsync(string role);
        Task<string> LoginAsync(LoginDTO userdto);
        Task RegisterAsync(RegisterDTO userdto);
        Task UpdateUserAsync(UpdateUserDTO userdto,int userId);
        Task DeleteUserAsync(int id);
    }
}
