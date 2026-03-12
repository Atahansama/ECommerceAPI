using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Core.DTOs.User
{
    public class UpdateUserDTO
    {
        [Required(ErrorMessage ="First Name can not be blank")]
        [MaxLength(20)]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last Name can not be blank")]
        [MaxLength(20)]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email can not be blank")]
        [EmailAddress(ErrorMessage ="Email should be in proper email format")]
        public string Email { get; set; } = string.Empty;
    }
}
