using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Core.DTOs.Address
{
    public class UpdateAddressDTO
    {
        [Required]
        public int AddressID { get; set; }
            
        [Required(ErrorMessage = "Title can not be blank")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Full Address can not be blank")]
        public string FullAddress { get; set; } = string.Empty;

        [Required(ErrorMessage = "City can not be blank")]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "District can not be blank")]
        public string District { get; set; } = string.Empty;
    }
}
