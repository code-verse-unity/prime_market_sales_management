using DomainLayer.Models.PriceModel;
using DomainLayer.Models.ProductModel;
using DomainLayer.Models.StockModel;
using InfrastructureLayer.Repositories.Price;
using InfrastructureLayer.Repositories.Product;
using InfrastructureLayer.Repositories.Stock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermarket_sales_manegement.UserControls
{
    public partial class NewStockForm : Form
    {
        ProductUserControl parent;
        public NewStockForm(ProductUserControl productUserControl)
        {
            InitializeComponent();

            parent = productUserControl;
            LoadProductsIntoComboBox();
        }

        private void LoadProductsIntoComboBox()
        {
            ProductList.Items.Add("Selectionner le produit...");
            foreach (var item in new ProductRepository().GetAll())
            {
                ProductList.Items.Add(item);
            }

            ProductList.SelectedIndex = 0;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddInStockButton_Click(object sender, EventArgs e)
        {
            bool validated = ProductList.SelectedIndex > 0 &&
                ProductPrice.Value > 0 &&
                ProductQuatity.Value > 0;

            if (!validated)
            {
                MessageBox.Show("Veuillez remplir correctement tous les champs requis");
            }
            else
            {

                DateTime stockDate = DateTime.Now;

                if (ProductList.SelectedIndex > 0)
                {
                    ProductModel product = (ProductModel)ProductList.SelectedItem;

                    PriceModel price = new PriceModel()
                    {
                        ProductId = product.Id,
                        Date = stockDate,
                        UnitPrice = (double)ProductPrice.Value,
                    };
                    StockModel stock;
                    if (product.IsPerishable)
                    {

                        DateTime expirationDate = ProductExpirationDate.Value;
                        if (expirationDate <= DateTime.Now)
                        {
                            MessageBox.Show("Veuillez spécifier une date d'expiration valide");
                            return;
                        }

                        stock = new StockModel()
                        {
                            ProductId = product.Id,
                            CreatedAt = stockDate,
                            Quantity = (int)ProductQuatity.Value,
                            ExpirationDate = expirationDate
                        };
                    }
                    else
                    {
                        stock = new StockModel()
                        {
                            ProductId = product.Id,
                            CreatedAt = stockDate,
                            Quantity = (int)ProductQuatity.Value,
                            ExpirationDate = null,
                        };
                    }

                    new PriceRepository().Add(price);
                    new StockRepository().Add(stock);
                    new ProductRepository().UpdateCump(product.Id);

                    parent.LoadProductsIntoDataGridView(new ProductRepository().GetAll());
                    Close();
                }
            }
        }

        private void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductList.SelectedIndex > 0)
            {
                ProductModel product = (ProductModel)ProductList.SelectedItem;

                if (product.IsPerishable)
                {
                    ProductExpirationDate.Enabled = true;
                }
                else
                {
                    ProductExpirationDate.Enabled = false;
                }
            }
        }
    }
}
