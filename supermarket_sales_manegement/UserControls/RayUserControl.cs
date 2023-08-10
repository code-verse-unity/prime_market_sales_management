using DomainLayer.Models.CategoryModel;
using InfrastructureLayer.Repositories.CategoryRepository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace supermarket_sales_manegement.UserControls
{
    public partial class RayUserControl : UserControl
    {
        private ICategoryRepository categoryRepository;

        public RayUserControl(DockStyle dockStyle)
        {
            InitializeComponent();
            categoryRepository = new CategoryRepository();
            LoadCategoryIntoDataGridView();
        }

        private void LoadCategoryCount(IEnumerable<ICategoryModel> categories)
        {
            categoryCount.Text = categories.Count().ToString();
        }

        public void LoadCategoryIntoDataGridView()
        {
            CategoryDataGridView.Columns.Clear();

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


            // Add the column to the DataGridView
            CategoryDataGridView.Columns.Add(editButton);
            CategoryDataGridView.Columns.Add(deleteButton);
            CategoryDataGridView.Columns.Add("Id", "ID");
            CategoryDataGridView.Columns.Add("Name", "Nom du rayon");
            CategoryDataGridView.Columns.Add("RayNumber", "Numéro de l'allée");

            CategoryDataGridView.Columns["Id"].DataPropertyName = "Id";
            CategoryDataGridView.Columns["Name"].DataPropertyName = "Name";
            CategoryDataGridView.Columns["RayNumber"].DataPropertyName = "RayNumber";

            IEnumerable<ICategoryModel> categories = categoryRepository.GetAll();
            CategoryDataGridView.DataSource = categories;
            LoadCategoryCount(categories);


            if (CategoryDataGridView.Columns.Contains("DeletedAt"))
            {
                CategoryDataGridView.Columns["DeletedAt"].Visible = false; // hide the delete_at column
            }
        }

        private void RayUserControl_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form
            {
                FormBorderStyle = FormBorderStyle.FixedSingle,
                MaximizeBox = false,
                Width = 340,
                Height = 390,
                StartPosition = FormStartPosition.CenterScreen
            };
            form.Controls.Add(new AddRayUserControl(form, this));
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            DataGridViewRow row = senderGrid.CurrentRow;

            CategoryModel category = new CategoryModel
            {
                Id = int.Parse(row.Cells["Id"].Value.ToString()),
                Name = row.Cells["Name"].Value.ToString(),
                RayNumber = int.Parse(row.Cells["RayNumber"].Value.ToString()),
                DeletedAt = null
            };

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (senderGrid.Columns[e.ColumnIndex].Name == "edit")
                {
                    UpdateRayForm updateRayForm = new UpdateRayForm(category, this);
                    updateRayForm.ShowDialog();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Etes-vous sur de vouloir supprimer cets rayon", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        categoryRepository.Delete(category);
                        LoadCategoryIntoDataGridView();
                    }
                }
            }
        }
    }
}
