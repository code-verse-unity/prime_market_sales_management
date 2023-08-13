using DomainLayer.Models.CategoryModel;
using DomainLayer.Models.ProductModel;
using DomainLayer.Models.ProductPurchaseModel;
using DomainLayer.Models.PurchaseModel;
using InfrastructureLayer.Repositories.PurchaseRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermarket_sales_manegement.UserControls.PurchaseUserControl
{
    public partial class AddPurchaseForm : Form
    {
        private IPurchaseRepository purchaseRepository;
        private List<ProductModel> products;
        private IEnumerable<IProductModel> productsToShow;
        private IEnumerable<ICategoryModel> categories;
        private List<ProductPurchaseModel> productPurchases; // productId as key
        private ProductModel selectedProductModel = null;

        private CategoryModel allCategoryModel = new CategoryModel
        {
            Id = -1,
            Name = "Toutes catégories",
            RayNumber = -1,
        };

        public AddPurchaseForm()
        {
            InitializeComponent();
            purchaseRepository = new PurchaseRepository();

            // TODO fetch from repository
            products = new List<ProductModel>() {
                new ProductModel
            {
                Id = 1,
                Name = "BabaneBabaneBabaneBabaneBabaneBabaneBabane",
                CategoryId = 1,
                IsPerishable = true,
                Unit = "kg",
                Cump = 100,
                Stock = 20,
                DeleteAt = null,
            },
                new ProductModel
                {
                    Id = 2,
                    Name = "Coco",
                    CategoryId = 21,
                    IsPerishable = false,
                    Unit = "pcs",
                    Cump = 50,
                    Stock = 10,
                    DeleteAt = null,
                }
            };

            // TODO fetch from repository
            categories = new List<CategoryModel>()
            {
                new CategoryModel {
                    Id = 1,
                    Name = "Fruits",
                    RayNumber = 2,
                },
                new CategoryModel {
                    Id =21,
                    Name = "Légumes",
                    RayNumber = 4,
                },
            };

            productPurchases = new List<ProductPurchaseModel>();
            productsToShow = new List<ProductModel>();

            InitProductCategoryComboBox();
            ReloadProductPurchaseDataGridView();
        }


        private void InitProductPurchaseDataGridView()
        {
            ReloadProductPurchaseDataGridView();
        }

        private void ReloadProductDataGridView()
        {
            ProductDataGridView.DataSource = productsToShow.ToList();

            ProductDataGridView.Columns["Name"].HeaderText = "Nom";
            ProductDataGridView.Columns["Stock"].HeaderText = "Quantité en stock";
            ProductDataGridView.Columns["Unit"].HeaderText = "Unité";
            ProductDataGridView.Columns["Cump"].HeaderText = "Prix unitaire";
            ProductDataGridView.Columns["Id"].Visible = false;
            ProductDataGridView.Columns["CategoryId"].Visible = false;
            ProductDataGridView.Columns["IsPerishable"].Visible = false;
            ProductDataGridView.Columns["DeleteAt"].Visible = false; // Change to DeletedAt
        }

        private void ReloadProductPurchaseDataGridView()
        {
            ProductPurchaseDataGridView.Columns.Clear();

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
            {
                HeaderText = "Suppression",
                Text = "Supprimer",
                UseColumnTextForButtonValue = true,
            };

            ProductPurchaseDataGridView.Columns.Insert(0, deleteButton);

            ProductPurchaseDataGridView.DataSource = productPurchases.ToList();
            ProductPurchaseDataGridView.Columns["Id"].Visible = false;
            ProductPurchaseDataGridView.Columns["ProductId"].Visible = false;
            ProductPurchaseDataGridView.Columns["PurchaseId"].Visible = false;
            ProductPurchaseDataGridView.Columns["Product"].DisplayIndex = 1;
            ProductPurchaseDataGridView.Columns["Price"].DisplayIndex = 2;
            ProductPurchaseDataGridView.Columns["Quantity"].DisplayIndex = 3;
            ProductPurchaseDataGridView.Columns["SubTotal"].DisplayIndex = 4;
            ProductPurchaseDataGridView.Columns["Quantity"].HeaderText = "Quantité";
            ProductPurchaseDataGridView.Columns["SubTotal"].HeaderText = "Sous-total";
            ProductPurchaseDataGridView.Columns["Product"].HeaderText = "Désignation";
            ProductPurchaseDataGridView.Columns["Price"].HeaderText = "Prix unitaire";
        }

        private void ReloadTotalLabel()
        {
            double total = 0;
            productPurchases.ForEach(productPurchase => total += productPurchase.SubTotal);
            TotalLabel.Text = total.ToString();
        }

        private void InitProductCategoryComboBox()
        {
            List<ICategoryModel> values = new List<ICategoryModel> { allCategoryModel };

            foreach (ICategoryModel categoryModel in categories)
            {
                values.Add(categoryModel);
            }

            ProductCategoryComboBox.DataSource = values;
            ProductCategoryComboBox.DisplayMember = "Name";
            ProductCategoryComboBox.ValueMember = "Id";
        }

        private void ProductCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductCategoryComboBox.SelectedItem != null)
            {
                ICategoryModel selectedCategoryModel = (ICategoryModel)ProductCategoryComboBox.SelectedItem;

                // TODO filter products based on the categoryId
                if (selectedCategoryModel.Id == -1) // here we have the all category
                {
                    productsToShow = products.ToList(); // Copy the value not the reference
                }
                else
                {
                    productsToShow = products.Where(product => product.CategoryId == selectedCategoryModel.Id).ToList();
                }

                ReloadProductDataGridView();
            }
        }

        private void ReloadAddToCartPanel()
        {
            if (selectedProductModel != null)
            {
                ProductNameLabel.Text = selectedProductModel.Name;

                ProductQuantityInStockLabel.Text = selectedProductModel.Stock.ToString();
                // ProductQuantityNumericUpDown.Maximum = 10000; // TODO set to real max value
                ProductPurchaseModel productPurchaseModel = productPurchases.Find(productPurchase => productPurchase.ProductId == selectedProductModel.Id);
                if (productPurchaseModel != null)
                {
                    ProductQuantityNumericUpDown.Maximum = productPurchaseModel.Quantity + selectedProductModel.Stock;
                    ProductQuantityNumericUpDown.Value = productPurchaseModel.Quantity;
                }
                else
                {
                    ProductQuantityNumericUpDown.Maximum = selectedProductModel.Stock;
                    ProductQuantityNumericUpDown.Value = 0;
                }
            }
            else
            {
                ProductNameLabel.Text = "";

                ProductQuantityInStockLabel.Text = "";

                ProductQuantityNumericUpDown.Value = 0;
                ProductQuantityNumericUpDown.Maximum = 0;
            }
        }

        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ProductDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ProductDataGridView.SelectedRows[0];
                selectedProductModel = (ProductModel)selectedRow.DataBoundItem;
            }
            else
            {
                selectedProductModel = null;
            }

            ReloadAddToCartPanel();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (selectedProductModel != null)
            {
                ProductPurchaseModel productPurchaseModel = productPurchases.Find(productPurchase => productPurchase.ProductId == selectedProductModel.Id);

                int newQuantity = Convert.ToInt32(ProductQuantityNumericUpDown.Value);

                // already in the cart
                if (productPurchaseModel != null)
                {

                    selectedProductModel.Stock = selectedProductModel.Stock + productPurchaseModel.Quantity - newQuantity; // Reset the quantity in stock
                    productPurchaseModel.Quantity = newQuantity;

                    if (newQuantity == 0)
                    {
                        productPurchases.Remove(productPurchaseModel);
                    }
                }
                else if (newQuantity > 0) // add to cart if it have a quantity
                {
                    productPurchaseModel = new ProductPurchaseModel
                    {
                        ProductId = selectedProductModel.Id,
                        Price = selectedProductModel.Cump,
                        Quantity = Convert.ToInt32(ProductQuantityNumericUpDown.Value),
                        Product = products.Find(product => product.Id == selectedProductModel.Id),
                    };
                    selectedProductModel.Stock = selectedProductModel.Stock - productPurchaseModel.Quantity;
                    productPurchases.Add(productPurchaseModel);
                }

                ReloadProductPurchaseDataGridView();
                ReloadTotalLabel();
                ProductDataGridView.Refresh();
                ReloadAddToCartPanel();
            }
        }

        private void ProductPurchaseDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && ProductPurchaseDataGridView.Columns["Product"] != null && e.ColumnIndex == ProductPurchaseDataGridView.Columns["Product"].Index)
            {
                ProductPurchaseModel productPurchaseModel = (ProductPurchaseModel)ProductPurchaseDataGridView.Rows[e.RowIndex].DataBoundItem;
                if (productPurchaseModel != null)
                {
                    e.Value = productPurchaseModel.Product.Name;
                    e.FormattingApplied = true;
                }
            }
        }

        private void ProductQuantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (selectedProductModel != null)
            {
                ProductPurchaseModel productPurchaseModel = productPurchases.Find(productPurchase => productPurchase.ProductId == selectedProductModel.Id);

                int newQuantity = Convert.ToInt32(ProductQuantityNumericUpDown.Value);

                if (productPurchaseModel != null)
                {
                    ProductQuantityInStockLabel.Text = Convert.ToString(selectedProductModel.Stock + productPurchaseModel.Quantity - newQuantity);
                }
                else
                {
                    ProductQuantityInStockLabel.Text = Convert.ToString(selectedProductModel.Stock - newQuantity);
                }
            }
        }

        private void ProductPurchaseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (ProductPurchaseDataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    ProductPurchaseModel productPurchaseModel = (ProductPurchaseModel)ProductPurchaseDataGridView.Rows[e.RowIndex].DataBoundItem;

                    if (ProductPurchaseDataGridView.Columns[e.ColumnIndex].HeaderText == "Suppression")
                    {
                        HandleRemoveFromCart(productPurchaseModel);
                    }
                }
            }
        }

        private void HandleRemoveFromCart(ProductPurchaseModel productPurchaseModel)
        {
            ProductModel productModel = products.Find(product => product.Id == productPurchaseModel.ProductId);
            productModel.Stock = productModel.Stock + productPurchaseModel.Quantity;
            productPurchases.Remove(productPurchaseModel);
            ReloadProductPurchaseDataGridView();
            ReloadTotalLabel();
            ProductDataGridView.Refresh();
            ReloadAddToCartPanel();
        }

        private void PerformPurchaseButton_Click(object sender, EventArgs e)
        {
            if (productPurchases.Count > 0)
            {
                PurchaseModel purchaseModel = new PurchaseModel
                {
                    CreatedAt = DateTime.Now,
                    ProductPurchases = productPurchases,
                };

                purchaseRepository.Add(purchaseModel);
                
                this.Close();
                MessageBox.Show("Achat éffecté avec succès.", "Achat éffecté", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
