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
            DialogResult result = MessageBox.Show($"Hello {name}!", "Felhasználó köszöntése", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
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
    }
}
