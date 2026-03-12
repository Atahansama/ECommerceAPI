using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Core.DTOs.Cart
{
    public class CreateCartDTO
    {
        [Required(ErrorMessage ="Product Id can not be blank")]
        public int ProductID { get; set; }

        [Required(ErrorMessage ="Quantity can not be empty")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        public int Quantity { get; set; }
    }
}
