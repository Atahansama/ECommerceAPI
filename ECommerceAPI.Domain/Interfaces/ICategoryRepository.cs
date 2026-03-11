using ECommerceAPI.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Domain.Interfaces
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<Category?> GetCategoryByUrlAsync(string url);
        Task<Category?> GetCategoryByIdAsync(int id);
        Task DeleteProductsByCategory(int productId,int categoryId);
    }
}
