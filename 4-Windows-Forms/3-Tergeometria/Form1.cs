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
        private List<Shape> shapes = new List<Shape>();
        private Shape shape;

        public Form1()
        {
            InitializeComponent();
            AreaNumUpDown.Maximum = Int64.MaxValue;
            VolumeNumUpDown.Maximum = Int64.MaxValue;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (!rb.Checked) return;
            //ImgPanel.BackgroundImage = Image.FromFile($"../../assets/{rb.Tag}.png");
            double r = (double)RadiusNumUpDown.Value;
            double h = (double)HeightNumUpDown.Value;
            switch (rb.Tag)
            {
                case "sphere":
                    ImgPanel.BackgroundImage = Properties.Resources.sphere;
                    shape = new Sphere(r);
                    break;
                case "cylinder":
                    ImgPanel.BackgroundImage = Properties.Resources.cylinder;
                    shape = new Cylinder(r, h);
                    break;
                case "cone":
                    ImgPanel.BackgroundImage = Properties.Resources.cone;
                    shape = new Cone(r, h);
                    break;
            }
            HeightNumUpDown.Enabled = rb.Tag.ToString() != "sphere";
            ButtonPanel.Enabled = true;
            AreaNumUpDown.Value = 0;
            VolumeNumUpDown.Value = 0;
            AreaNumUpDown.BackColor = SystemColors.Window;
            VolumeNumUpDown.BackColor = SystemColors.Window;

            Shape largestShape = shapes.Where(s => s.GetType() == shape.GetType())
                                       .OrderByDescending(s => s.Volume)
                                       .FirstOrDefault();
            if (largestShape != null)
            {
                LargestLabel.Visible = true;
                LargestLabel.Text = "Legnagyobb térfogatú " + largestShape;
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            double r = random.Next(101) / 10.0; // [0,1) * 100 => [0, 100) => [0..99] / 10 => [0.0..9.9]
            double h = random.Next(101) / 10.0;
            RadiusNumUpDown.Value = (decimal)r;
            HeightNumUpDown.Value = HeightNumUpDown.Enabled ? (decimal)h : 0;
            shape.r = r;
            shape.h = h;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            AreaNumUpDown.Value = (decimal)shape.Area;
            VolumeNumUpDown.Value = (decimal)shape.Volume;
        }

        private void NumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (shape == null) return;
            shape.r = (double)RadiusNumUpDown.Value;
            shape.h = (double)HeightNumUpDown.Value;
            AreaNumUpDown.Value = 0;
            VolumeNumUpDown.Value = 0;
            AreaNumUpDown.BackColor = SystemColors.Window;
            VolumeNumUpDown.BackColor = SystemColors.Window;
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            bool isCorrent = Math.Round(AreaNumUpDown.Value, 1) == (decimal)Math.Round(shape.Area, 1);
            //MessageBox.Show($"{Math.Round(AreaNumUpDown.Value, 1)} {(decimal)Math.Round(shape.Area, 1, MidpointRounding.AwayFromZero)}");
            AreaNumUpDown.BackColor = isCorrent ? Color.LightGreen : Color.LightPink;
            isCorrent = Math.Round(VolumeNumUpDown.Value, 1) == (decimal)Math.Round(shape.Volume, 1);
            VolumeNumUpDown.BackColor = isCorrent ? Color.LightGreen : Color.LightPink;
        }

        private void UpdateListBox()
        {
            ShapeListBox.Items.Clear();
            ShapeListBox.Items.AddRange(shapes.ToArray());
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            shapes.Add(shape);
            shape = shape.Clone() as Shape;
            UpdateListBox();
        }

        private void ShapeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shape shape = ShapeListBox.SelectedItem as Shape;
            RadiusNumUpDown.Value = (decimal)shape.r;
            HeightNumUpDown.Value = (decimal)shape.h;
            if (shape is Sphere) SphereRadioBtn.Checked = true;
            else if (shape is Cylinder) CylinderRadioBtn.Checked = true;
            else if (shape is Cone) ConeRadioBtn.Checked = true;
        }
    }
}
