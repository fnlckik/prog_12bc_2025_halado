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
        public Form1()
        {
            InitializeComponent();
        }

        private void HelloBtn_Click(object sender, EventArgs e)
        {
            // Project properties -> Output Type -> Console Application
            //Console.WriteLine("Hello Világ!");
            //Debug.WriteLine("Hello Világ!");
            DialogResult result = MessageBox.Show("Hello Világ!", "Felhasználó köszöntése", MessageBoxButtons.YesNo);
            MessageBox.Show((result == DialogResult.Yes).ToString());
        }
    }
}
