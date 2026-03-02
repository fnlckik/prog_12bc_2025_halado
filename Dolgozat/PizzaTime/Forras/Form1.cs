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
            DialogResult result = dialog.ShowDialog();
            if (result != DialogResult.OK) return;
        }
    }
}
