using DomainLayer.Models.CategoryModel;
using InfrastructureLayer.Repositories.CategoryRepository;
using System;
using System.Windows.Forms;

namespace supermarket_sales_manegement.UserControls
{
    public partial class UpdateRayForm : Form
    {
        readonly ICategoryModel  _category;
        readonly CategoryRepository _repository;
        readonly RayUserControl _userControl;

        public UpdateRayForm(ICategoryModel category, RayUserControl rayUserControl)
        {
            InitializeComponent();
            _category = category;
            _repository = new CategoryRepository();
            _userControl = rayUserControl;
            InitializeForm();
        }

        private void InitializeForm()
        {
            categoryName.Text = _category.Name;
            rayNumber.Value = _category.RayNumber;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _category.Name = categoryName.Text;
            _category.RayNumber = int.Parse(rayNumber.Value.ToString());

            _repository.Update(_category);

            _userControl.LoadCategoryIntoDataGridView();
            Close();
        }
    }
}
