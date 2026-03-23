using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Kings
{
    public partial class Form1 : Form
    {
        private List<King> kings;
        private string[] headers;

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.InitialDirectory = Application.StartupPath;
            DialogResult result = dialog.ShowDialog();
            if (result != DialogResult.OK) return;
            ReadFromFile(dialog.FileName);
        }

        private void ReadFromFile(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                headers = sr.ReadLine().Split(';');
                kings = new List<King>();
                while (!sr.EndOfStream)
                {
                    string[] temp = sr.ReadLine().Split(';');
                    int start = int.Parse(temp[0]);
                    int end = int.Parse(temp[1]);
                    string name = temp[2];
                    int year = int.Parse(temp[3]);
                    string place = temp[4];
                    string dynasty = temp[5];
                    King k = new King(name, year, place, start, end, dynasty);
                    kings.Add(k);
                }
            }
            ShowKings();
        }

        private void ShowKings()
        {
            KingsDataGrid.ColumnCount = headers.Length - 1;
            for (int i = 0; i < KingsDataGrid.ColumnCount; i++)
            {
                KingsDataGrid.Columns[i].HeaderCell.Value = headers[i];
            }

            //KingsDataGrid.RowCount = kings.Count;
            //for (int i = 0; i < kings.Count; i++)
            //{
            //    DataGridViewRow r = KingsDataGrid.Rows[i];
            //    r.Cells[0].Value = kings[i].Start;
            //    r.Cells[1].Value = kings[i].End;
            //    r.Cells[2].Value = kings[i].Name;
            //    r.Cells[3].Value = kings[i].Year;
            //    r.Cells[4].Value = kings[i].Place;
            //}

            KingsDataGrid.Rows.Clear();
            foreach (King k in kings)
            {
                KingsDataGrid.Rows.Add(k.Start, k.End, k.Name, k.Year, k.Place);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFromFile("kings.txt");
        }
    }
}
