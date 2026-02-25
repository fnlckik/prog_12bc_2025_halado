using System;
using System.Collections.Generic;
using System.Drawing;
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
            MaterialDataGrid.Columns.Clear();
            MaterialDataGrid.ColumnCount = 8;
            MaterialDataGrid.RowCount = (int)Math.Ceiling(1d * 101 / 8);
            for (int i = 0; i < data.Count; i++)
            {
                MaterialDataGrid.Rows[i / 8].Cells[i % 8].Value = data[i];
                MaterialDataGrid.Rows[i / 8].Height = MaterialDataGrid.Columns[i % 8].Width;
            }

            Control.ControlCollection controls = this.Controls;
        }

        // 25% 50-59; 70% 60-89; 5% 90-99
        private int Generate(Random r)
        {
            int p = r.Next(1, 101);
            if (p <= 25) return r.Next(50, 60);
            else if (p <= 95) return r.Next(60, 90);
            else return r.Next(90, 100);
        }
    }
}
