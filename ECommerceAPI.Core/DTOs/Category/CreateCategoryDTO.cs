using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Core.DTOs.Category
{
    public class CreateCategoryDTO
    {
        [Required(ErrorMessage = "Category Name can not be blank")]
        [MaxLength(50,ErrorMessage="Category Name can not be that long")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "URL can not be blank")]
        public string Url { get; set; } = string.Empty;
    }
}
