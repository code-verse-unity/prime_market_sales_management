using DomainLayer.Models.CategoryModel;
using DomainLayer.Models.ProductModel;
using InfrastructureLayer.Repositories.Category;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace supermarket_sales_manegement.UserControls.Product
{
    public partial class UpdateProductForm : Form
    {
        private IProductModel Product;
        private ProductUserControl parent;
        public UpdateProductForm(IProductModel product, ProductUserControl userControl)
        {
            InitializeComponent();
            Product = product;
            parent = userControl;

            InitializeUpdateForm();
        }

        private void InitializeUpdateForm()
        {
            ProductName.Text = Product.Name;
            Console.WriteLine(Product.Price);
            ProductPrice.Value = (decimal)Product.Price;
            ProductUnitName.Text = Product.Unit;

            CategoryRepository categoryRepository = new CategoryRepository();
            IEnumerable<ICategoryModel> categories = categoryRepository.GetAll();

            ProductCategory.Items.Add("Choisir un rayon...");
            foreach (ICategoryModel category in categories)
            {
                ProductCategory.Items.Add(category);
            }

            ProductCategory.SelectedItem = Product.Category;

            ProductIsPerishable.Checked = Product.IsPerishable;
            //ProductExpirationDate.Value = Product.Expira
        }
    }
}
