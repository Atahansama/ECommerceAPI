using ECommerceAPI.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Core.DTOs.Product
{
    public class ProductDTO
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string URL { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public double Rating { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; } = string.Empty;
        public string ImageURL { get; set; } = string.Empty;
        public bool IsHome { get; set; }
        public bool IsApproved { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.UtcNow;
        public List<string> Categories { get; set; } = new();

    }
}
