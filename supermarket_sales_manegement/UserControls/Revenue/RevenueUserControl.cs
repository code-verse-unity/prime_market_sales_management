using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainLayer.Models.RevenueModel;
using InfrastructureLayer.Repositories.Revenue;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;

namespace supermarket_sales_manegement.UserControls.Revenue
{
    public partial class RevenueUserControl : UserControl
    {
        private DockStyle dockStyle;
        private IEnumerable<IRevenueModel> revenues;
        private IRevenueRepository revenueRepository;

        public RevenueUserControl(DockStyle dockStyle)
        {
            InitializeComponent();
            this.dockStyle = dockStyle;
            revenueRepository = new RevenueRepository();
            InitYearNumericUpDown();
            ReloadView();
        }

        private void ReloadView()
        {
            ReloadRevenues();
            ReloadRevenueChart();
            ReloadRevenueDataGridView();
            ReloadYearLabel();
            ReloadAmountLabel();
        }

        private void InitYearNumericUpDown()
        {
            YearNumericUpDown.Minimum = DateTime.MinValue.Year;
            YearNumericUpDown.Maximum = DateTime.MaxValue.Year;
            YearNumericUpDown.Value = DateTime.Now.Year;
        }

        private void ReloadRevenueDataGridView()
        {
            RevenueDataGridView.Columns.Clear();
            RevenueDataGridView.DataSource = revenues.ToList();

            RevenueDataGridView.Columns["Year"].Visible = false;
            RevenueDataGridView.Columns["Amount"].HeaderText = "Montant";
            RevenueDataGridView.Columns["Month"].HeaderText = "Mois";
            RevenueDataGridView.Columns["Month"].DisplayIndex = 0;
            RevenueDataGridView.Columns["Amount"].DisplayIndex = 1;

            RevenueDataGridView.Columns["Month"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            RevenueDataGridView.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void ReloadRevenues()
        {
            IEnumerable<IRevenueModel> revenuesFromDB = revenueRepository.GetAllByYear(Convert.ToInt32(YearNumericUpDown.Value));

            Dictionary<int, IRevenueModel> idRevenue = new Dictionary<int, IRevenueModel>();

            foreach (IRevenueModel revenue in revenuesFromDB)
            {
                idRevenue.Add(revenue.Month - 1, revenue);
            }

            for (int i = 0; i < 12; i++)
            {
                if (!idRevenue.ContainsKey(i))
                {
                    idRevenue.Add(i, new RevenueModel
                    {
                        Amount = 0,
                        Month = i + 1,
                    }
                    );
                }
            }

            List<IRevenueModel> result = new List<IRevenueModel>();

            for (int i = 0; i < 12; i++)
            {
                result.Add(idRevenue[i]);
            }

            revenues = result;
        }

        private void ReloadRevenueChart()
        {
            RevenueChart.Series.Clear();
            RevenueChart.ChartAreas.Clear();

            Series series = new Series("Montant par mois");
            series.ChartType = SeriesChartType.Column;
            series.BorderWidth = 3;

            // Create a list of month names in French
            List<string> frenchMonthNames = DateTimeFormatInfo.CurrentInfo.MonthNames.Take(12).ToList();

            foreach (IRevenueModel revenue in revenues)
            {
                int monthIndex = revenue.Month - 1;
                string monthName = frenchMonthNames[monthIndex];
                double total = revenue.Amount;
                series.Points.AddXY(monthName, total);
            }
            
            RevenueChart.Series.Add(series);
            RevenueChart.ChartAreas.Add(new ChartArea());
            RevenueChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        }

        private void RevenueUserControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void ReloadYearLabel()
        {
            YearLabel.Text = YearNumericUpDown.Value.ToString();
        }

        private void ReloadAmountLabel()
        {
            double result = 0;
            foreach (IRevenueModel revenue in revenues)
            {
                result += revenue.Amount;
            }
            AmountLabel.Text = FormatCurrency(result);
        }
        private string FormatCurrency(double number)
        {
            CultureInfo cultureInfo = new CultureInfo("de-DE");
            cultureInfo.NumberFormat.CurrencySymbol = "Ar";
            return number.ToString("C", cultureInfo);
        }

        private void YearNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ReloadView();
        }

        private void RevenueDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (RevenueDataGridView.Columns["Amount"] != null && e.ColumnIndex == RevenueDataGridView.Columns["Amount"].Index)
                {
                    IRevenueModel revenueModel = (IRevenueModel)RevenueDataGridView.Rows[e.RowIndex].DataBoundItem;
                    if (revenueModel != null)
                    {
                        e.Value = FormatCurrency(revenueModel.Amount);
                        e.FormattingApplied = true;
                    }
                }
                else if (RevenueDataGridView.Columns["Month"] != null && e.ColumnIndex == RevenueDataGridView.Columns["Month"].Index)
                {
                    IRevenueModel revenueModel = (IRevenueModel)RevenueDataGridView.Rows[e.RowIndex].DataBoundItem;
                    if (revenueModel != null)
                    {
                        List<string> frenchMonthNames = DateTimeFormatInfo.CurrentInfo.MonthNames.Take(12).ToList();
                        e.Value = frenchMonthNames[revenueModel.Month - 1];
                        e.FormattingApplied = true;
                    }
                }
            }
        }
    }
}
