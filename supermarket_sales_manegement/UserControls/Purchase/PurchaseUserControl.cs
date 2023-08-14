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
using TheArtOfDev.HtmlRenderer.PdfSharp;
using PdfSharp;
using System.IO;
using System.Diagnostics;
using System.Globalization;
using Humanizer;

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
            purchases = purchaseRepository.GetAllByDate(DateTime.Now);
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

            DataGridViewButtonColumn billButton = new DataGridViewButtonColumn
            {
                HeaderText = "Facture",
                Text = "Ouvrir",
                UseColumnTextForButtonValue = true,
            };
            
            PurchaseDataGridView.Columns.Insert(0, billButton);

            PurchaseDataGridView.Columns["CreatedAt"].HeaderText = "Date et heure d'achat";
            PurchaseDataGridView.Columns["ProductsCount"].HeaderText = "Nombres de produits";
            PurchaseDataGridView.Columns["ProductsCount"].DisplayIndex = 3;
            PurchaseDataGridView.Columns["ProductsCount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PurchaseDataGridView.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            PurchaseDataGridView.Columns["CreatedAt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            PurchaseDataGridView.Columns["ProductPurchases"].Visible = false;
        }

        private void PurchaseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (PurchaseDataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    IPurchaseModel purchaseModel = (IPurchaseModel)PurchaseDataGridView.Rows[e.RowIndex].DataBoundItem;
                    if (PurchaseDataGridView.Columns[e.ColumnIndex].HeaderText == "Facture")
                    {
                         HandleBillPurchase(purchaseModel);
                    }
                }
            }
        }

        private void HandleBillPurchase(IPurchaseModel purchaseModel)
        {
            string folder = "bills";
            string fileName = $"bill_{purchaseModel.Id}_{purchaseModel.CreatedAt.ToString("yyyy-MM-dd")}.pdf";
            string fullOutputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{folder}/{fileName}");

            if (!File.Exists(fullOutputPath))
            {
                StringBuilder tableStringBuilder = new StringBuilder();
                int i = 0;
                foreach (IProductPurchaseModel productPurchase in purchaseModel.ProductPurchases)
                {
                    string backgroundColor = i == 0 ? "#cfd8dc" : "#fff";
                    tableStringBuilder.Append(
                        $@"<tr>
                            <td style=""background-color: {backgroundColor}; text-align: left; font-weight: bold; padding: 5px 10px;"">
                                {productPurchase.Product.Name}
                            </td>
                            <td style=""background-color: {backgroundColor}; text-align: right; font-weight: right; padding: 5px 10px;"">
                                {FormatCurrency(productPurchase.Price)}
                            </td>
                            <td style=""background-color: {backgroundColor}; text-align: center; font-weight: center; padding: 5px 10px;"">
                                {productPurchase.Quantity}
                            </td>
                            <td style=""background-color: {backgroundColor}; text-align: right; font-weight: right; padding: 5px 10px;"">
                                {FormatCurrency(productPurchase.SubTotal)}
                            </td>
                        </tr>"
                    );

                    i = i == 0 ? 1 : 0;
                }

                string htmlContent = $@"<!DOCTYPE html>
<html lang = ""en"">
<head>
    <meta charset = ""UTF-8"">
    <meta http-equiv = ""X-UA-Compatible"" content = ""IE=edge"">
    <meta name = ""viewport"" content = ""width=device-width, initial-scale=1.0"">
    <title>Facture {purchaseModel.Id} | {purchaseModel.CreatedAt.ToString("yyyy-MM-dd")}</title>
</head>
<body style=""margin: 1rem; padding: 1rem 2rem 7rem 2rem;"">
    <div class=""bill-container"">
        <h1 style=""text-align: center; font-size: x-large; margin-bottom: 3rem;"">
            Facture : <span style=""font-weight: bold;"">{purchaseModel.Id}</span>
        </h1>
        
        <div style=""font-size: larger; font-weight: bold; margin-bottom: 1rem;"">
            Id : <span style=""font-weight: bold;"">{purchaseModel.Id}</span>
        </div>

        <div style=""font-size: larger; font-weight: bold; margin-bottom: 1rem;"">
            Date et heure : <span style=""font-weight: bold;"">{purchaseModel.CreatedAt.ToString("dd/MM/yyyy HH:mm")}</span>
        </div>

        <div style=""font-size: larger; font-weight: bold; margin-bottom: 1rem;"">
            Total : <span style=""font-weight: bold;"">{FormatCurrency(purchaseModel.Total)}</span>
        </div>

        <div style=""margin: 10px 0;"">
            <table style=""width: 90%; margin: 0 auto; border-collapse: collapse; border-spacing: 0;"">
                <thead>
                    <tr style=""background-color: #263238; color: red;"">
                        <th style=""text-align: center; padding: 5px 10px; border-right: solid 2px #fff; background-color: #263238; color: #fff;"">Désignation</th>
                        <th style=""text-align: center; padding: 5px 10px; border-right: solid 2px #fff; background-color: #263238; color: #fff;"">Prix Unitaire</th>
                        <th style=""text-align: center; padding: 5px 10px; border-right: solid 2px #fff; background-color: #263238; color: #fff;"">Quantité</th>
                        <th style=""text-align: center; padding: 5px 10px; background-color: #263238; color: #fff;"">Sous-Total</th>
                    </tr>
                </thead>
                <tbody>
                    {tableStringBuilder.ToString()}
                    <tr>
                        <td style=""border: none;""></td>
                        <td style=""border: none;""></td>
                        <td style=""text-align: center; background-color: #263238; color: #fff; font-weight: bold; letter-spacing: 0.2rem; border: solid 2px #263238; text-transform: uppercase;"">Total</td>
                        <td style=""text-align: right; padding: 5px 10px; font-weight: bold; border: solid 2px #263238;"">
                            {FormatCurrency(purchaseModel.Total)}
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>

        <p>Arrêté par la présente facture à la somme de
            <span style=""font-weight: bold; color: fff;"">
                {NumberToFullText(purchaseModel.Total)} Ariary
            </span>
        </p>
    </div>
</body>
</html>";
                
                PdfDocument pdf = PdfGenerator.GeneratePdf(htmlContent, PageSize.A4);

                Directory.CreateDirectory(folder);

                pdf.Save(fullOutputPath);
            }

            Process.Start(fullOutputPath);
        }

        string FormatCurrency(double number)
        {
            CultureInfo cultureInfo = new CultureInfo("de-DE");
            cultureInfo.NumberFormat.CurrencySymbol = "Ar";
            return number.ToString("C", cultureInfo);
        }

        private string NumberToFullText(double number)
        {
            // Convert the integer part of the number to full French text
            string integerPartText = ((int)number).ToWords(new CultureInfo("fr-FR"));

            // Get the fractional part of the number
            double fractionalPart = Math.Round(number - Math.Floor(number), 2);
            string fractionalPartText = FractionalToWords(fractionalPart);

            return $"{integerPartText} virgule {fractionalPartText}";
        }

        private string FractionalToWords(double fraction)
        {
            string[] numberWords = new string[] { "zéro", "un", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf" };
            int decimalPlaces = 2;

            string fractionalPartText = string.Empty;

            for (int i = 0; i < decimalPlaces; i++)
            {
                fraction *= 10;
                int digit = (int)Math.Floor(fraction);
                fractionalPartText += numberWords[digit] + " ";
                fraction -= digit;
            }

            return fractionalPartText.Trim();
       }

    private void AddPurchaseButton_Click(object sender, EventArgs e)
        {
            AddPurchaseForm addPurchaseForm = new AddPurchaseForm
            {
                FormBorderStyle = FormBorderStyle.FixedSingle,
                StartPosition = FormStartPosition.CenterScreen
            };

            addPurchaseForm.ShowDialog();

            purchases = purchaseRepository.GetAllByDate(DateTime.Now);

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
                PurchaseDateLabel.Text = selectedPurchaseModel.CreatedAt.ToString("dd/MM/yyyy HH:mm");
                PurchaseTotalLabel.Text = FormatCurrency(selectedPurchaseModel.Total);
                ProductsCountLabel.Text = selectedPurchaseModel.ProductsCount.ToString();
            }
            else
            {
                selectedPurchaseModel = null;
                productPurchases = new List<ProductPurchaseModel>();
                PurchaseIdLabel.Text = "";
                PurchaseDateLabel.Text = "";
                PurchaseTotalLabel.Text = FormatCurrency(0);
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
            ProductPurchaseDataGridView.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            ProductPurchaseDataGridView.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProductPurchaseDataGridView.Columns["SubTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void ProductPurchaseDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (ProductPurchaseDataGridView.Columns["Product"] != null && e.ColumnIndex == ProductPurchaseDataGridView.Columns["Product"].Index)
                {
                    ProductPurchaseModel productPurchaseModel = (ProductPurchaseModel)ProductPurchaseDataGridView.Rows[e.RowIndex].DataBoundItem;
                    if (productPurchaseModel != null)
                    {
                        e.Value = productPurchaseModel.Product.Name;
                        e.FormattingApplied = true;
                    }
                }
                else if (ProductPurchaseDataGridView.Columns["Price"] != null && e.ColumnIndex == ProductPurchaseDataGridView.Columns["Price"].Index)
                {
                    ProductPurchaseModel productPurchaseModel = (ProductPurchaseModel)ProductPurchaseDataGridView.Rows[e.RowIndex].DataBoundItem;
                    if (productPurchaseModel != null)
                    {
                        e.Value = FormatCurrency(productPurchaseModel.Price);
                        e.FormattingApplied = true;
                    }
                }
                else if (ProductPurchaseDataGridView.Columns["SubTotal"] != null && e.ColumnIndex == ProductPurchaseDataGridView.Columns["SubTotal"].Index)
                {
                    ProductPurchaseModel productPurchaseModel = (ProductPurchaseModel)ProductPurchaseDataGridView.Rows[e.RowIndex].DataBoundItem;
                    if (productPurchaseModel != null)
                    {
                        e.Value = FormatCurrency(productPurchaseModel.SubTotal);
                        e.FormattingApplied = true;
                    }
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

            RevenueLabel.Text = FormatCurrency(result);
        }

        private void PurchaseDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && PurchaseDataGridView.Columns["Total"] != null && e.ColumnIndex == PurchaseDataGridView.Columns["Total"].Index)
            {
                PurchaseModel productModel = (PurchaseModel)PurchaseDataGridView.Rows[e.RowIndex].DataBoundItem;
                if (productModel != null)
                {
                    e.Value = FormatCurrency(productModel.Total);
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
