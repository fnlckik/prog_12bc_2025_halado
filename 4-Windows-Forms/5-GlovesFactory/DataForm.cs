using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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
            for (int i = 0; i < 101; i++)
            {
                data.Add(Generate(r));
            }
            ShowData();
            Control.ControlCollection controls = this.Controls;
            foreach (Control control in controls)
            {
                control.Enabled = true;
            }
        }

        private void ShowData()
        {
            MaterialDataGrid.Columns.Clear();
            MaterialDataGrid.ColumnCount = 8;
            MaterialDataGrid.RowCount = (int)Math.Ceiling(1d * 101 / 8);
            for (int i = 0; i < data.Count; i++)
            {
                MaterialDataGrid.Rows[i / 8].Cells[i % 8].Value = data[i];
                MaterialDataGrid.Rows[i / 8].Height = MaterialDataGrid.Columns[i % 8].Width;
            }
            CalculateStats();
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

            }
        }
    }
}
