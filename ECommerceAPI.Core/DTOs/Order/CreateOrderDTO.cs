using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Core.DTOs.Order
{
    public class CreateOrderDTO
    {
        [Required(ErrorMessage ="Address can't be blank")]
        public int AddressID { get; set; }
    }
}
