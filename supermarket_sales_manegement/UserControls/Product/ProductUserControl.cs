using DomainLayer.Models.ProductModel;
using InfrastructureLayer.Repositories.Category;
using InfrastructureLayer.Repositories.Product;
using supermarket_sales_manegement.UserControls.Product;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace supermarket_sales_manegement.UserControls
{
    public partial class ProductUserControl : UserControl
    {
        private IEnumerable<IProductModel> products;
        private ProductRepository productRepository;
        private CategoryRepository categoryRepository;
        public ProductUserControl(DockStyle dockStyle)
        {
            InitializeComponent();
            productRepository = new ProductRepository();
            categoryRepository = new CategoryRepository();

            LoadProductsIntoDataGridView();
        }

        public void LoadProductsIntoDataGridView()
        {
            ProductsDataGridView.Columns.Clear();

            // Create a new DataGridViewButtonColumn
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn
            {
                // Set properties for the button column
                HeaderText = "Modification", // Column header text
                Text = "Modifier" // Text on the 
            };
            editButton.UseColumnTextForButtonValue = true;
            editButton.FillWeight = 40;
            editButton.Name = "edit";

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
            {
                // Set properties for the button column
                HeaderText = "Suppression", // Column header text
                Text = "Supprimer" // Text on the button
            };
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.FillWeight = 40;
            deleteButton.Name = "delete";

            DataGridViewCheckBoxColumn isPerishable = new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "IsPerishable",
                Name = "IsPerishable",
                HeaderText = "Perissable",
            };

            // Add the column to the DataGridView
            ProductsDataGridView.Columns.Add(editButton);
            ProductsDataGridView.Columns.Add(deleteButton);
            ProductsDataGridView.Columns.Add("Id", "ID");
            ProductsDataGridView.Columns.Add("Name", "Designation");
            ProductsDataGridView.Columns.Add(isPerishable);

            ProductsDataGridView.Columns.Add("Price", "Prix");
            ProductsDataGridView.Columns.Add("Unit", "Unité");
            ProductsDataGridView.Columns.Add("InStock", "En stock");
            ProductsDataGridView.Columns.Add("Category", "Rayon");

            ProductsDataGridView.Columns["Id"].DataPropertyName = "Id";
            ProductsDataGridView.Columns["Name"].DataPropertyName = "Name";
            ProductsDataGridView.Columns["Price"].DataPropertyName = "Price";
            ProductsDataGridView.Columns["Unit"].DataPropertyName = "Unit";
            ProductsDataGridView.Columns["InStock"].DataPropertyName = "InStock";
            ProductsDataGridView.Columns["Category"].DataPropertyName = "Category";


            products = productRepository.GetAll();
            ProductsDataGridView.DataSource = products;
            ProductsDataGridView.CellFormatting += ProductsDataGridView_CellFormatting;

            if (ProductsDataGridView.Columns.Contains("DeletedAt") || ProductsDataGridView.Columns.Contains("CategoryId"))
            {
                ProductsDataGridView.Columns["DeletedAt"].Visible = false; // hide the delete_at column
                ProductsDataGridView.Columns["CategoryId"].Visible = false;
            }
        }

        private void ProductsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 10 && e.RowIndex >= 0)
            {
                ProductModel currentProduct = ProductsDataGridView.Rows[e.RowIndex].DataBoundItem as ProductModel;

                if (currentProduct != null)
                {
                    e.Value = currentProduct.Category.ToString();
                    e.FormattingApplied = true;
                }
            }
        }

        private void ProductUserControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddProductForm updateRayForm = new AddProductForm(this);
            updateRayForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewStockForm  newStockForm = new NewStockForm();
            newStockForm.ShowDialog();
        }

        private void ProductsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            DataGridViewRow row = senderGrid.CurrentRow;

            int categoryId = int.Parse(row.Cells["CategoryId"].Value.ToString());

            ProductModel product = new ProductModel()
            {
                Id = int.Parse(row.Cells["Id"].Value.ToString()),
                Name = row.Cells["Name"].Value.ToString(),
                CategoryId = categoryId,
                InStock = int.Parse(row.Cells["InStock"].Value.ToString()),
                IsPerishable = (bool)row.Cells["IsPerishable"].Value,
                Price = (double)row.Cells["Price"].Value,
                Unit = row.Cells["Unit"].Value.ToString(),
                Category = categoryRepository.GetById(categoryId)
            };


            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (senderGrid.Columns[e.ColumnIndex].Name == "edit")
                {
                    UpdateProductForm updateProductForm = new UpdateProductForm(product, this);
                    updateProductForm.ShowDialog();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Etes-vous sur de vouloir supprimer cet produit", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        productRepository.Delete(product);
                        LoadProductsIntoDataGridView();
                    }
                }
            }
        }
    }
    
}

