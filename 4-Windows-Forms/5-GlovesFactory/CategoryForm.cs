using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GlovesFactory
{
    public partial class CategoryForm : Form
    {
        private List<int> data;
        private List<string> categories;

        public CategoryForm(List<int> data, List<string> categories)
        {
            InitializeComponent();
            this.data = data;
            this.categories = categories;
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            CategoriesDataGrid.Font = new Font("Microsoft Sans Serif", 12);
            //CategoriesDataGrid.Columns.Add("Frequencies", "Gyakoriságok");
            CategoriesDataGrid.RowCount = categories.Count;
            for (int i = 0; i < categories.Count; i++)
            {
                CategoriesDataGrid.Rows[i].HeaderCell.Value = categories[i];
                CategoriesDataGrid.Rows[i].Cells[0].Value = CountCategory(categories[i]);
                CategoriesDataGrid.Rows[i].Cells[0].Tag = i;
            }
            CategoriesDataGrid.TopLeftHeaderCell.Value = "Kategóriák";
            CategoriesDataGrid.Columns[0].HeaderCell.Value = "Gyakoriságok";
            //CategoriesDataGrid.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            ShowDiagram();
        }

        private void ShowDiagram()
        {
            Series series = CategoriesChart.Series[0];
            series.ChartType = SeriesChartType.Pie;
            series["PieLabelStyle"] = "Outside"; // CustomProperties

            foreach (DataGridViewRow row in CategoriesDataGrid.Rows)
            {
                double value = double.Parse(row.Cells[0].Value.ToString());
                string category = row.HeaderCell.Value.ToString();
                double degree = value / data.Count * 360;

                if (value != 0)
                {
                    DataPoint p = new DataPoint();
                    p.SetValueY(value);
                    p.LegendText = category;
                    p.ToolTip = $"{Math.Round(degree)}°";
                    p.BorderColor = Color.Black;
                    p.Label = value.ToString();
                    series.Points.Add(p);
                }
            }
        }

        // "50 - 54 m^2", "55 - 59 m^2"
        private int CountCategory(string category)
        {
            int min = int.Parse(category.Split(' ')[0]);
            int max = min + 4;
            return data.Count(x => min <= x && x <= max);
        }

        private void CategoriesDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (CategoriesDataGrid.Rows.Count == 0) return;
            if (CategoriesDataGrid.SelectedCells.Count == 0) return;
            if (CategoriesChart.Series[0].Points.Count == 0) return;
            
            DataGridViewCell selectedCell = CategoriesDataGrid.SelectedCells[0];
            //int rowIndex = selectedCell.RowIndex;
            int rowIndex = (int)selectedCell.Tag;

            foreach (DataPoint point in CategoriesChart.Series[0].Points)
            {
                point["Exploded"] = "false";
            }
            DataPoint p = CategoriesChart.Series[0].Points[rowIndex];
            p["Exploded"] = "true";
        }
    }
}
