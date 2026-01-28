using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Hello
{
    public partial class Form1 : Form
    {
        // enum => felsorolás
        private enum Hetvege
        {
            Pentek = 5,
            Szombat = 6,
            Vasarnap = 7
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void HelloBtn_Click(object sender, EventArgs e)
        {
            // Project properties -> Output Type -> Console Application
            //Console.WriteLine("Hello Világ!");
            //Debug.WriteLine("Hello Világ!");
            // (MessageBoxButtons)4 == MessageBoxButtons.YesNo
            string name = NameTextBox.Text;
            if (name != "")
            {
                GreetLabel.Text = $"Hello {name}!";
            }
            //DialogResult result = MessageBox.Show($"Hello {name}!", "Felhasználó köszöntése", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            //if (result == DialogResult.Yes)
            //{
            //    MessageBox.Show("Az IGEN gombra nyomtál!");
            //}
            //else if (result == DialogResult.No)
            //{
            //    MessageBox.Show("Az NEM gombra nyomtál!");
            //}
            //else
            //{
            //    MessageBox.Show("A MÉGSE gombra nyomtál!");
            //}
            //switch (result)
            //{
            //    case DialogResult.Cancel:
            //        MessageBox.Show("A MÉGSE gombra nyomtál!");
            //        break;
            //    case DialogResult.Yes:
            //        MessageBox.Show("Az IGEN gombra nyomtál!");
            //        break;
            //    case DialogResult.No:
            //        MessageBox.Show("Az NEM gombra nyomtál!");
            //        break;
            //}
            //MessageBox.Show($"{(int)Hetvege.Szombat}");
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            HelloBtn.Enabled = name != "";
            //if (name != "")
            //{
            //    GreetLabel.Text = $"Hello {name}!";
            //}
        }

        private void BoldCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //GreetLabel.Font.Bold = false;
            FontStyle newStyle = BoldCheckBox.Checked ? FontStyle.Bold | FontStyle.Italic : FontStyle.Italic;
            GreetLabel.Font = new Font(GreetLabel.Font, newStyle);
            //GreetLabel.Font = new Font(GreetLabel.Font, (FontStyle)(BoldCheckBox.Checked ? 1 : 0) + 2);
        }

        // e => event (Esemény objektum.)
        // sender => e.target (Ő váltotta ki az eseményt.)
        private void ColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (!rb.Checked) return;
            switch (rb.Tag) // rb.Text
            {
                case "R":
                    GreetLabel.ForeColor = Color.FromArgb(192, 0, 0);
                    break;
                case "G":
                    GreetLabel.ForeColor = Color.Green;
                    break;
                case "B":
                    GreetLabel.ForeColor = Color.Blue;
                    break;
            }
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            MouseEventArgs ev = e as MouseEventArgs;
            PositionLabel.Text = $"P({ev.X};{ev.Y})";

            //int x = (Panel.Size.Width - PositionLabel.Size.Width) / 2;
            //int y = PositionLabel.Location.Y;
            //PositionLabel.Location = new Point(x, y);
            PositionLabel.Left = (Panel.Width - PositionLabel.Width) / 2;
        }
    }
}
