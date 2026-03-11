using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Domain.Entites
{
    public class Cart
    {
        public int CartId { get; set; }
        public string UserID { get; set; } = string.Empty;
        public int ProductID { get; set; }
        public Product Product { get; set; } = null!;
        public int Quantity { get; set; }

    }
}
