using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Core.DTOs.User
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "First Name can not be blank")]
        [MaxLength(20)]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last Name can not be blank")]
        [MaxLength(20)]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email can not be blank")]
        [EmailAddress(ErrorMessage = "Email should be be in proper email format")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password can not be blank")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{6,}$", ErrorMessage = "Password must contain at least one uppercase, one lowercase and one number")]

        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Confirm Password can not be blank")]
        [Compare("Password",ErrorMessage ="Passwords do not match")]
        public string ConfirmPassword {  get; set; } = string.Empty;
    }
}
