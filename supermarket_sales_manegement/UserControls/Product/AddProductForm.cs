using DomainLayer.Models.CategoryModel;
using DomainLayer.Models.PriceModel;
using DomainLayer.Models.ProductModel;
using DomainLayer.Models.StockModel;
using InfrastructureLayer.Repositories.Category;
using InfrastructureLayer.Repositories.Product;
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
        ProductUserControl parent;
        public AddProductForm(ProductUserControl productUserControl)
        {
            InitializeComponent();
            parent = productUserControl;

            InitializeForm();
        }

        private void InitializeForm()
        {
            CategoryRepository categoryRepository =  new CategoryRepository();
            IEnumerable<ICategoryModel> categories = categoryRepository.GetAll();

            ProductCategory.Items.Add("Choisir un rayon...");
            foreach (ICategoryModel category in categories)
            {
                ProductCategory.Items.Add(category);
            }

            ProductCategory.SelectedIndex = 0;
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            bool validated = 
                ProductName.Text != "" &&
                ProductPrice.Value > 0 && 
                ProductUnitName.Text != "" &&
                ProductQuatity.Value > 0 && ProductCategory.SelectedIndex > 0;

            if (!validated)
            {
                MessageBox.Show("Veuillez remplir correctement tous les champs requis");
            }
            else
            {
                IPriceModel priceModel = new PriceModel()
                {
                    UnitPrice = (double)ProductPrice.Value,
                };

                bool isPerishable = ProductIsPerishable.Checked;
                DateTime? expirationDate;
                if (isPerishable)
                {
                    expirationDate = ProductExpirationDate.Value;
                    if(expirationDate <= DateTime.Now)
                    {
                        MessageBox.Show("Veuillez spécifier une date d'expiration valide");
                        return;
                    }
                }
                else
                    expirationDate = null;

                IStockModel stockModel = new StockModel()
                {
                    ExpirationDate = expirationDate,
                    Quantity = (int)ProductQuatity.Value,
                };

                if (ProductCategory.SelectedIndex > 0)
                {
                    IProductModel productModel = new ProductModel()
                    {
                        CategoryId = ((CategoryModel)ProductCategory.SelectedItem).Id,
                        IsPerishable = isPerishable,
                        Name = ProductName.Text,
                        Unit = ProductUnitName.Text
                    };

                    ProductRepository productRepository = new ProductRepository();
                    productRepository.Add(productModel, priceModel, stockModel);

                    parent.LoadProductsIntoDataGridView(productRepository.GetAll());
                    Close();
                }
            }
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProductIsPerishable_CheckedChanged(object sender, EventArgs e)
        {
            if(ProductIsPerishable.Checked)
            {
                ProductIsPerishable.Text = "Oui";
                ProductExpirationDate.Enabled = true;
            }
            else
            {
                ProductIsPerishable.Text = "Non";
                ProductExpirationDate.Enabled = false;
            }
        }
    }
}
