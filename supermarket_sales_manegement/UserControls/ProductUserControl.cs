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
    public partial class ProductUserControl : UserControl
    {
        public ProductUserControl(DockStyle dockStyle)
        {
            InitializeComponent();
        }

        private void ProductUserControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddProductForm updateRayForm = new AddProductForm();
            updateRayForm.ShowDialog();
        }
    }
}
