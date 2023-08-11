using DomainLayer.Models.CategoryModel;
using DomainLayer.Models.PriceModel;
using DomainLayer.Models.ProductModel;
using DomainLayer.Models.StockModel;
using InfrastructureLayer.Repositories.CategoryRepository;
using InfrastructureLayer.Repositories.ProductRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermarket_sales_manegement.UserControls
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            CategoryRepository categoryRepository =  new CategoryRepository();
            IEnumerable<ICategoryModel> categories = categoryRepository.GetAll();

            ProductCategory.Items.Add("Choisir un rayon...");
            foreach (ICategoryModel category in categories)
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(category.Id);
                stringBuilder.Append(category.Name);
                ProductCategory.Items.Add(stringBuilder.ToString());
            }

            ProductCategory.SelectedIndex = 0;
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            IPriceModel priceModel = new PriceModel()
            {
                UnitPrice = 20,
            };
            IStockModel stockModel = new StockModel()
            {
                ExpirationDate = DateTime.Now,
                Quantity = 30,
            };
            IProductModel productModel = new ProductModel()
            {
                CategoryId = 1,
                IsPerishable = true,
                Name = "Test",
                Unit = "KG"
            };

            ProductRepository productRepository = new ProductRepository();
            productRepository.Add(productModel, priceModel, stockModel);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
