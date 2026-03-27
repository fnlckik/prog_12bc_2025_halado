using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Tickets
{
    public partial class Form1 : Form
    {
        private List<Ticket> tickets;
        private int totalPrice;

        public Form1()
        {
            InitializeComponent();
            totalPrice = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SeatsDataGrid.ColumnCount = 10;
            SeatsDataGrid.RowCount = 7;
            int price = 6500;
            foreach (DataGridViewRow row in SeatsDataGrid.Rows)
            {
                row.Height = SeatsDataGrid.Height / 7;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = price;
                    cell.Style.BackColor = Color.LightGreen;
                }
                price -= 300;
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result != DialogResult.OK) return;
            using (StreamReader sr = new StreamReader(dialog.FileName))
            {
                tickets = new List<Ticket>();
                while (!sr.EndOfStream)
                {
                    string[] temp = sr.ReadLine().Split(';');
                    Ticket t = new Ticket(int.Parse(temp[0]), int.Parse(temp[1]));
                    tickets.Add(t);
                }
            }
            ReserveButton.Enabled = true;
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            foreach (Ticket ticket in tickets)
            {
                int i = ticket.Row - 1;
                int j = ticket.Seat - 1;
                DataGridViewCell cell = SeatsDataGrid.Rows[i].Cells[j];
                cell.Value = "-";
                cell.Style.BackColor = Color.LightPink;
            }
        }

        private void EmptySeatsButton_Click(object sender, EventArgs e)
        {
            var selected = SeatsDataGrid.SelectedCells;
            int count = 0;
            foreach (DataGridViewCell cell in selected)
            {
                if (cell.Value.ToString() != "-")
                {
                    count++;
                }
            }
            EmptySeatsLabel.Text = "Szabad helyek száma: " + count;
        }

        private void ReserveButton_Click(object sender, EventArgs e)
        {
            if (SeatsDataGrid.SelectedCells.Count == 0)
            {
                MessageBox.Show("Nincs kiválasztva szabad hely!");
                return;
            }
            DataGridViewCell cell = SeatsDataGrid.SelectedCells[0];
            if (cell.Value.ToString() == "-")
            {
                MessageBox.Show("Nincs kiválasztva szabad hely!");
                return;
            }
            totalPrice += (int)cell.Value;
            cell.Value = "-";
            cell.Style.BackColor = Color.LightPink;
            ReserveLabel.Text = "Foglalás értéke: " + totalPrice + " Ft";

            int i = cell.RowIndex;
            int j = cell.ColumnIndex;
            Ticket t = new Ticket(i + 1, j + 1);
            tickets.Add(t);
        }
    }
}
