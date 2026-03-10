using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GlovesFactory
{
    public partial class DataForm : Form
    {
        private List<int> data;

        public DataForm()
        {
            InitializeComponent();
        }

        private void RandomMenuItem_Click(object sender, EventArgs e)
        {
            data = new List<int>();
            Random r = new Random();
            for (int i = 0; i < 123; i++)
            {
                data.Add(Generate(r));
            }
            EnableControls();
            CategoryComboBox.SelectedIndex = 0;
        }

        private void ShowData(List<int> data)
        {
            MaterialDataGrid.Columns.Clear();
            MaterialDataGrid.ColumnCount = 8;
            MaterialDataGrid.RowCount = (int)Math.Ceiling(1d * data.Count / 8);
            for (int i = 0; i < data.Count; i++)
            {
                MaterialDataGrid.Rows[i / 8].Cells[i % 8].Value = data[i];
                MaterialDataGrid.Rows[i / 8].Height = MaterialDataGrid.Columns[i % 8].Width;
            }
            CalculateStats();
        }

        // 50-54; 55-59; 60-64; ...; 95-99
        private void EnableControls()
        {
            Control.ControlCollection controls = this.Controls;
            foreach (Control control in controls)
            {
                control.Enabled = true;
            }
            CategoryComboBox.Items.Clear();
            CategoryComboBox.Items.Add("Minden adat..");
            for (int i = 50; i <= 95; i += 5)
            {
                CategoryComboBox.Items.Add($"{i} - {i+4} m\u00B2");
            }
            StatsMenuItem.Enabled = true;
        }

        private void CalculateStats()
        {
            int n = data.Count;
            MagnitudeLabel.Text = "Terjedelem: " + (data.Max() - data.Min());
            double avg = data.Average();
            AverageLabel.Text = "Átlag: " + Math.Round(avg, 2);
            double spread = Math.Sqrt(data.Aggregate(0.0, (result, current) => result + Math.Pow(avg - current, 2)) / n);
            SpreadLabel.Text = "Szórás: " + Math.Round(spread);
            var ordered = data.OrderBy(x => x).ToList();
            if (n % 2 == 1)
            {
                // 1 2 3 4 5
                // Sorszám: 3 -> (n+1)/2
                // Index: 2 -> (n+1)/2 - 1
                MedianLabel.Text = "Medián: " + ordered[n / 2];
            }
            else
            {
                // 1 2 3 4 5 6
                // Sorszám: 3 4 -> n/2 és n/2 + 1
                // Index: 2 3 -> n/2 - 1 és n/2
                MedianLabel.Text = "Medián: " + (ordered[n / 2 - 1] + ordered[n / 2]) / 2.0;
            }
            BottomNumUpDown.Value = data.Min();
            TopNumUpDown.Value = data.Max();
        }

        // 25% 50-59; 70% 60-89; 5% 90-99
        private int Generate(Random r)
        {
            int p = r.Next(1, 101);
            if (p <= 25) return r.Next(50, 60);
            else if (p <= 95) return r.Next(60, 90);
            else return r.Next(90, 100);
        }

        private void FileMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Szöveges fájl|*.txt";
            dialog.InitialDirectory = Application.StartupPath;
            DialogResult result = dialog.ShowDialog();
            if (result != DialogResult.OK) return;
            string fileName = dialog.FileName;
            using (StreamReader sr = new StreamReader(fileName))
            {
                string[] temp = sr.ReadLine().Split();
                data = temp.Select(x => int.Parse(x)).ToList();
            }
            EnableControls();
            CategoryComboBox.SelectedIndex = 0;
        }

        private void ExtremeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int min = (int)BottomNumUpDown.Value;
            int max = (int)TopNumUpDown.Value;
            foreach (DataGridViewRow row in MaterialDataGrid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    ColorCell(cell, min, max);
                }
            }
        }

        private void ColorCell(DataGridViewCell cell, int min, int max)
        {
            cell.Style.BackColor = Color.White;
            if (!ExtremeCheckBox.Checked) return;
            if (cell.Value != null && Convert.ToInt32(cell.Value) < min)
            {
                cell.Style.BackColor = Color.LightPink;
            }
            else if (cell.Value != null && Convert.ToInt32(cell.Value) > max)
            {
                cell.Style.BackColor = Color.LightGreen;
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedIndex == 0)
            {
                ShowData(data);
                return;
            }
            string category = CategoryComboBox.SelectedItem.ToString();
            int min = int.Parse(category.Substring(0, 2)); // Take(2)
            int max = min + 4;
            var filtered = data.Where(x => min <= x && x <= max).ToList();
            ShowData(filtered);
        }

        private void ColumnMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(((int)SeriesChartType.Column).ToString());
            List<int> selected = GetSelection();
            if (selected.Count == 0) return;
            DiagramForm diagram = new DiagramForm(selected, SeriesChartType.Column);
            diagram.Show();
        }

        private void LineMenuItem_Click(object sender, EventArgs e)
        {
            List<int> selected = GetSelection();
            if (selected.Count == 0) return;
            DiagramForm diagram = new DiagramForm(selected, SeriesChartType.Line);
            diagram.Show();
        }

        private List<int> GetSelection()
        {
            var temp = MaterialDataGrid.SelectedCells;
            List<int> result = new List<int>();
            foreach (DataGridViewCell cell in temp)
            {
                if (cell.Value != null)
                {
                    result.Add((int)cell.Value);
                }
            }
            result.Reverse();
            // selected.Reverse<int>().ToList()
            // (selected as IEnumerable<int>).Reverse().ToList()
            // Enumerable.Reverse(selected).ToList()
            return result;
        }

        private void FreqMenuItem_Click(object sender, EventArgs e)
        {
            List<string> categories = CategoryComboBox.Items.Cast<string>().Skip(1).ToList();
            CategoryForm form = new CategoryForm(data, categories);
            form.Show();
        }
    }
}
