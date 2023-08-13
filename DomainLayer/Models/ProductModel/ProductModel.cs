using DomainLayer.Models.CategoryModel;
using DomainLayer.Models.PriceModel;
using System;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models.ProductModel
{
    public class ProductModel : IProductModel
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Product name required")]
        public string Name { get; set; }

        public int CategoryId { get; set; }

        [Required( ErrorMessage = "Product perishable status required")]
        public bool IsPerishable { get ; set ; }

        public DateTime? DeletedAt { get ; set ; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Product unit required")]
        public string Unit { get ; set ; }

        public double Price { get; set; } // CUMP
        public int InStock { get; set; }

        public ICategoryModel Category { get; set; }

    }
}
