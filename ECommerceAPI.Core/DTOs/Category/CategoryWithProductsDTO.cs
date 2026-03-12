using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Core.DTOs.Category
{
    public class CategoryWithProductsDTO
    {
        public int CategoryID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public List<string> Products { get; set; } = new();

    }
}
