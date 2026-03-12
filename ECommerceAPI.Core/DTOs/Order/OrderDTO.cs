using ECommerceAPI.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Core.DTOs.Order
{
    public class OrderDTO
    {
        public int OrderID { get; set; }
        public int UserID { get; set; } 
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public decimal TotalPrice { get; set; }
        public string OrderStatus { get; set; } = "Pending";
        public List<string> Products { get; set; } = new();

        public List<OrderItemDTO> OrderItems { get; set; } = new();

    }
}
