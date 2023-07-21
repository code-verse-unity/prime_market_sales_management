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
    public partial class RayUserControl : UserControl
    {
        public RayUserControl(DockStyle dockStyle)
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RayUserControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;
            form.Width = 340;
            form.Height = 390;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Controls.Add(new AddRayUserControl(form));
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (senderGrid.Columns[e.ColumnIndex].Name == "edit")
                {
                    UpdateRayForm updateRayForm = new UpdateRayForm();
                    updateRayForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Etes-vous sur de vouloir supprimer cets rayon", "Suppression");

                    
                }
            }
        }
    }
}
