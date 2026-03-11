using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Domain.Entites
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Role {  get; set; } = "Customer";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public List<Order> Orders { get; set; } = new();
        public List<Cart> Carts { get; set; } = new();
        public List<Address> Addresses { get; set; } = new();

    }
}
