using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Core.DTOs.Cart
{
    public class UpdateCartDTO
    {
        [Required(ErrorMessage ="Cart Id can not be blank")]
        public int CartId { get; set; }

        [Required(ErrorMessage ="Cart Id can not be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        public int Quantity { get; set; }


    }
}
