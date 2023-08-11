using DomainLayer.Models.CategoryModel;
using InfrastructureLayer.Repositories.Category;
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
    public partial class AddRayUserControl : UserControl
    {
        private readonly Form _parent;
        private CategoryRepository categoryRepository;
        private readonly RayUserControl _rayUserControl;

        public AddRayUserControl(Form parent, RayUserControl rayUserControl)
        {
            InitializeComponent();
            _parent = parent;
            _rayUserControl = rayUserControl;
            categoryRepository = new CategoryRepository();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoryModel category = new CategoryModel
            {
                Name = categoryName.Text,
                RayNumber = (int)categoryRayNumber.Value,
            };

            categoryRepository.Add(category);

            _rayUserControl.LoadCategoryIntoDataGridView();
            _parent.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _parent.Close();
        }
    }
}
