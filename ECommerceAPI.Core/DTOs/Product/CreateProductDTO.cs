using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Core.DTOs.Product
{
    public class CreateProductDTO
    {
        [Required(ErrorMessage="Product Name can not be blank")]
        [MaxLength(50,ErrorMessage ="Product Name can not be that long")]
        public string ProductName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Description can not be blank")]
        [MaxLength(100,ErrorMessage ="Description can not be that long")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Price can not be empty")]
        [Range(0.01,(double)Decimal.MaxValue)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "URL can not be empty")]
        public string URL { get; set; } = string.Empty;

        [Required(ErrorMessage = "Stock can not be empty")]
        [Range(0,int.MaxValue)]
        public int Stock {  get; set; }
        public bool IsHome { get; set; }
        public string ImageURL { get; set; } = string.Empty;

        [Required(ErrorMessage = "CategoryIds can not be empty")]
        public int[] CategoryIDs { get; set; } = Array.Empty<int>();


    }
}
