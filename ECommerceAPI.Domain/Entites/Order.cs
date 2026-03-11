using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Domain.Entites
{
    public class Order
    {
        public int OrderID { get; set; }
        public string UserID { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public decimal TotalPrice { get; set; }
        public string OrderStatus { get; set; } = "Pending";

        public List<OrderItem> Items { get; set;} = new();

    }
}
