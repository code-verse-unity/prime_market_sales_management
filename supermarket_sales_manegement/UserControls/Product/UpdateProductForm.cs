using DomainLayer.Models.CategoryModel;
using DomainLayer.Models.ProductModel;
using InfrastructureLayer.Repositories.Category;
using InfrastructureLayer.Repositories.Product;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace supermarket_sales_manegement.UserControls.Product
{
    public partial class UpdateProductForm : Form
    {
        private IProductModel Product;
        private ProductUserControl parent;
        private ProductRepository productRepository;
        public UpdateProductForm(IProductModel product, ProductUserControl userControl)
        {
            InitializeComponent();
            Product = product;
            parent = userControl;
            productRepository = new ProductRepository();

            InitializeUpdateForm();
        }

        private void InitializeUpdateForm()
        {
            ProductName.Text = Product.Name;

            ProductPrice.Value = (decimal)Product.Price;
            ProductUnitName.Text = Product.Unit;

            CategoryRepository categoryRepository = new CategoryRepository();
            IEnumerable<ICategoryModel> categories = categoryRepository.GetAll();

            ProductCategory.Items.Add("Choisir un rayon...");

            int selectedIndex = 0, index = 0;
            foreach (ICategoryModel category in categories)
            {
                if(category.Id == Product.CategoryId)
                {
                    selectedIndex = index;
                }
                ProductCategory.Items.Add(category);

                index++;
            }

            ProductCategory.SelectedIndex = selectedIndex + 1;

            ProductIsPerishable.Checked = Product.IsPerishable;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            if (ProductCategory.SelectedIndex > 0)
            {
                ProductModel product = new ProductModel()
                {
                    Id = Product.Id,
                    Name = ProductName.Text,
                    Price = (double)ProductPrice.Value,
                    Unit = ProductUnitName.Text,
                    IsPerishable = ProductIsPerishable.Checked,
                    Category = ProductCategory.SelectedItem as CategoryModel,
                };

                productRepository.Update(product);
                parent.LoadProductsIntoDataGridView();
                Close();
            }
               
        }
    }
}
