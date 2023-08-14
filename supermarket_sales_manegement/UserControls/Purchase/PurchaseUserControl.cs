using DomainLayer.Models.PurchaseModel;
using DomainLayer.Models.ProductPurchaseModel;
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
using PdfSharp.Pdf;
using PdfSharp.Drawing;

namespace supermarket_sales_manegement.UserControls.Purchase
{
    public partial class PurchaseUserControl : UserControl
    {
        private IPurchaseRepository purchaseRepository;
        private IEnumerable<IPurchaseModel> purchases;
        private IPurchaseModel selectedPurchaseModel;
        private IEnumerable<IProductPurchaseModel> productPurchases;

        public PurchaseUserControl(DockStyle dockStyle)
        {
            InitializeComponent();
            purchaseRepository = new PurchaseRepository();
            productPurchases = new List<ProductPurchaseModel>();
            purchases = purchaseRepository.GetAll();
            ReloadPurchaseDataGridView();
            ReloadProductPurchaseDataGridView();
            ReloadRevenueLabel();
            ReloadPurchaseProductCountLabel();
        }

        private void SaleUserControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ReloadPurchaseDataGridView()
        {
            PurchaseDataGridView.Columns.Clear();

            PurchaseDataGridView.DataSource = purchases.ToList();

            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn
            {
                HeaderText = "Modification",
                Text = "Modifier",
                UseColumnTextForButtonValue = true,
            };

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
            {
                HeaderText = "Annulation",
                Text = "Annuler",
                UseColumnTextForButtonValue = true,
            };

            DataGridViewButtonColumn billButton = new DataGridViewButtonColumn
            {
                HeaderText = "Facture",
                Text = "Ouvrir",
                UseColumnTextForButtonValue = true,
            };

            PurchaseDataGridView.Columns.Insert(0, editButton);
            PurchaseDataGridView.Columns.Insert(1, deleteButton);
            PurchaseDataGridView.Columns.Insert(2, billButton);

            PurchaseDataGridView.Columns["CreatedAt"].HeaderText = "Date et heure d'achat";
            PurchaseDataGridView.Columns["ProductsCount"].HeaderText = "Nombres de produits";
            PurchaseDataGridView.Columns["ProductsCount"].DisplayIndex = 5;

            PurchaseDataGridView.Columns["ProductPurchases"].Visible = false;
        }

        private void PurchaseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (PurchaseDataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    IPurchaseModel purchaseModel = (IPurchaseModel)PurchaseDataGridView.Rows[e.RowIndex].DataBoundItem;
                    switch (PurchaseDataGridView.Columns[e.ColumnIndex].HeaderText)
                    {
                        case "Modification":
                            HandleEditPurchase(purchaseModel);
                            break;
                        case "Annulation":
                            HandleDeletePurchase(purchaseModel);
                            break;
                        case "Facture":
                            HandleBillPurchase(purchaseModel);
                            break;
                    }
                }
            }
        }

        private void HandleBillPurchase(IPurchaseModel purchaseModel)
        {
            PdfDocument pdf = new PdfDocument();

            PdfPage page = pdf.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            string htmlContent = $"<h1> {purchaseModel.Id} </h1>";

            // TODO create the pdf
        }

        private void HandleDeletePurchase(IPurchaseModel purchaseModel)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir d'annuler cette vente ?", "Annulation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                purchaseRepository.Delete(purchaseModel);
            }
        }

        private void HandleEditPurchase(IPurchaseModel purchaseModel)
        {
            throw new NotImplementedException();
        }

        private void AddPurchaseButton_Click(object sender, EventArgs e)
        {
            AddPurchaseForm addPurchaseForm = new AddPurchaseForm
            {
                FormBorderStyle = FormBorderStyle.FixedSingle,
                StartPosition = FormStartPosition.CenterScreen
            };

            addPurchaseForm.ShowDialog();

            purchases = purchaseRepository.GetAll();

            ReloadPurchaseDataGridView();
            ReloadRevenueLabel();
            ReloadPurchaseProductCountLabel();
        }

        private void PurchaseDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (PurchaseDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = PurchaseDataGridView.SelectedRows[0];
                selectedPurchaseModel = (IPurchaseModel)selectedRow.DataBoundItem;
                productPurchases = selectedPurchaseModel.ProductPurchases;
                PurchaseIdLabel.Text = selectedPurchaseModel.Id.ToString();
                PurchaseDateLabel.Text = selectedPurchaseModel.CreatedAt.ToString(); // TODO format date
                PurchaseTotalLabel.Text = selectedPurchaseModel.Total.ToString();
                ProductsCountLabel.Text = selectedPurchaseModel.ProductsCount.ToString();
            }
            else
            {
                selectedPurchaseModel = null;
                productPurchases = new List<ProductPurchaseModel>();
                PurchaseIdLabel.Text = "";
                PurchaseDateLabel.Text = "";
                PurchaseTotalLabel.Text = "0";
                ProductsCountLabel.Text = "0";
            }

            ReloadProductPurchaseDataGridView();
        }

        private void ReloadProductPurchaseDataGridView()
        {
            ProductPurchaseDataGridView.Columns.Clear();

            ProductPurchaseDataGridView.DataSource = productPurchases.ToList();
            ProductPurchaseDataGridView.Columns["Id"].Visible = false;
            ProductPurchaseDataGridView.Columns["ProductId"].Visible = false;
            ProductPurchaseDataGridView.Columns["PurchaseId"].Visible = false;
            ProductPurchaseDataGridView.Columns["Product"].DisplayIndex = 0;
            ProductPurchaseDataGridView.Columns["Price"].DisplayIndex = 1;
            ProductPurchaseDataGridView.Columns["Quantity"].HeaderText = "Quantité";
            ProductPurchaseDataGridView.Columns["SubTotal"].HeaderText = "Sous-total";
            ProductPurchaseDataGridView.Columns["Product"].HeaderText = "Désignation";
            ProductPurchaseDataGridView.Columns["Price"].HeaderText = "Prix unitaire";
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PurchaseCreatedAtDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            purchases = purchaseRepository.GetAllByDate(PurchaseCreatedAtDateTimePicker.Value);

            ReloadPurchaseDataGridView();
            ReloadRevenueLabel();
            ReloadPurchaseProductCountLabel();
        }

        private void ReloadPurchaseProductCountLabel()
        {
            int result = 0;

            foreach (IPurchaseModel purchaseModel in purchases)
            {
                result += purchaseModel.ProductsCount;
            }

            PurchaseProductCountLabel.Text = result.ToString();
        }

        private void ReloadRevenueLabel()
        {
            double result = 0;

            foreach (IPurchaseModel purchaseModel in purchases)
            {
                result += purchaseModel.Total;
            }

            RevenueLabel.Text = result.ToString();
        }
    }
}
