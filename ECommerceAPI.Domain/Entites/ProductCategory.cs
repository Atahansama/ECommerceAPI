using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Domain.Entites
{
    public class ProductCategory
    {
        public int ProductID { get; set; }
        public Product Product { get; set; } = null!;
        public int CategoryID { get; set; }
        public Category Category { get; set; } = null!;


    }
}
