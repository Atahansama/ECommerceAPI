using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Core.DTOs.Order
{
    public class UpdateOrderDTO
    {
        [Required]
        public int OrderID { get; set; }

        [Required]
        public string OrderStatus { get; set; } = string.Empty;

    }
}
