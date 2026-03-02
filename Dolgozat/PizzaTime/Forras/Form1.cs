using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PizzaTime
{
    public partial class Form1 : Form
    {
        private List<Pizza> pizzas = new List<Pizza>();
        private string type;

        public Form1()
        {
            InitializeComponent();
        }

        private void Radio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (!rb.Checked) return;
            type = rb.Tag.ToString();
            AddButton.Enabled = true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Pizza pizza = new Pizza(type, FamilyCheckBox.Checked, (int)AmountNumeric.Value);
            pizzas.Add(pizza);
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            PizzaListBox.DataSource = null;
            PizzaListBox.DataSource = pizzas;
            int cost = pizzas.Sum(x => x.Cost);
            CostLabel.Text = "Fizetendő összeg: " + cost + " Ft";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string address = AddressTextBox.Text;
            if (name == "" || address == "")
            {
                MessageBox.Show("Add meg a neved és a rendelés címét!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Szöveges fájl|*.txt";
            dialog.InitialDirectory = Application.StartupPath;
            DialogResult result = dialog.ShowDialog();
            if (result != DialogResult.OK) return;
            string path = dialog.FileName;
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine($"{name};{address}");
                foreach (Pizza pizza in pizzas)
                {
                    string size = pizza.isFamily ? "1" : "0";
                    sw.WriteLine($"{pizza.type};{size};{pizza.amount}");
                }
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Application.StartupPath;
            DialogResult result = dialog.ShowDialog();
            if (result != DialogResult.OK) return;
            string path = dialog.FileName;
            using (StreamReader sr = new StreamReader(path))
            {
                string[] temp = sr.ReadLine().Split(';');
                NameTextBox.Text = temp[0];
                AddressTextBox.Text = temp[1];
                pizzas.Clear();
                while (!sr.EndOfStream)
                {
                    temp = sr.ReadLine().Split(';');
                    Pizza p = new Pizza(temp[0], temp[1] == "1", int.Parse(temp[2]));
                    pizzas.Add(p);
                }
            }
            UpdateListBox();
        }

        private void PizzaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pizza p = PizzaListBox.SelectedItem as Pizza;
            if (p == null) return;
            if (p.type == "Songoku") SongokuRadio.Checked = true;
            else if (p.type == "Magyaros") MagyarosRadio.Checked = true;
            else if (p.type == "Négysajtos") NegysajtosRadio.Checked = true;
            FamilyCheckBox.Checked = p.isFamily;
            AmountNumeric.Value = p.amount;
            DeleteButton.Visible = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int index = PizzaListBox.SelectedIndex;
            pizzas.RemoveAt(index);
            DeleteButton.Visible = false;
            UpdateListBox();
        }
    }
}
