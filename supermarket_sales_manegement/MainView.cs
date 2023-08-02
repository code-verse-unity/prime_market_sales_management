using supermarket_sales_manegement.UserControls;
using System;
using System.Windows.Forms;

namespace supermarket_sales_manegement
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();

            // Initialize the Ray view
            outled.Controls.Add(new RayUserControl(Dock = DockStyle.Fill));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            outled.Controls.Clear();
            outled.Controls.Add(new RayUserControl(Dock = DockStyle.Fill));
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            outled.Controls.Clear();
            outled.Controls.Add(new ProductUserControl(Dock = DockStyle.Fill));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            outled.Controls.Clear();
            outled.Controls.Add(new SaleUserControl(Dock = DockStyle.Fill));
        }
    }
}
