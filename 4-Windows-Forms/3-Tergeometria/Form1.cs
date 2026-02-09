using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Tergeometria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (!rb.Checked) return;
            //ImgPanel.BackgroundImage = Image.FromFile($"../../assets/{rb.Tag}.png");
            switch (rb.Tag)
            {
                case "sphere":
                    ImgPanel.BackgroundImage = Properties.Resources.sphere;
                    break;
                case "cylinder":
                    ImgPanel.BackgroundImage = Properties.Resources.cylinder;
                    break;
                case "cone":
                    ImgPanel.BackgroundImage = Properties.Resources.cone;
                    break;
            }
            HeightNumUpDown.Enabled = rb.Tag.ToString() != "sphere";
            ButtonPanel.Enabled = true;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            MessageBox.Show(random.Next(100).ToString());
        }
    }
}
