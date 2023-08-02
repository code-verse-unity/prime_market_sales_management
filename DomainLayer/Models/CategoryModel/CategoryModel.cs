using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.CategoryModel
{
    public class CategoryModel : ICategoryModel
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Category name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Category ray number is required")]
        public int RayNumber { get; set; }
    }
}
