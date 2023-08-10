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

namespace supermarket_sales_manegement.UserControls
{
    public partial class SaleUserControl : UserControl
    {
        private IPurchaseRepository purchaseRepository;
        private IEnumerable<IPurchaseModel> purchases;

        public SaleUserControl(DockStyle dockStyle)
        {
            InitializeComponent();
            purchaseRepository = new PurchaseRepository();
            LoadPurchases();
            InitPurchaseDataGridView();
        }

        public void LoadPurchases()
        {
            purchases = purchaseRepository.GetAll();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void InitPurchaseDataGridView()
        {
            PurchaseDataGridView.Columns.Clear();

            PurchaseDataGridView.DataSource = purchases;

            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn
            {
                HeaderText = "Modification",
                Text = "Modifier",
                UseColumnTextForButtonValue = true,
            };

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
            {
                HeaderText = "Suppression",
                Text = "Supprimer",
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

            PurchaseDataGridView.Columns["CreatedAt"].HeaderText = "Date d'achat";

            PurchaseDataGridView.Columns["ProductPurchases"].Visible = false;
        }
    }
}
