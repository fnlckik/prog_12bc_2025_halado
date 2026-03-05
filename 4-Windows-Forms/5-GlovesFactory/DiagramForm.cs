using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GlovesFactory
{
    public partial class DiagramForm : Form
    {
        private List<int> data;
        private SeriesChartType type;

        public DiagramForm(List<int> data, SeriesChartType type)
        {
            InitializeComponent();
            this.data = data;
            this.type = type;
        }

        private void DiagramForm_Load(object sender, EventArgs e)
        {
            // Adatsor használata
            Series series = DataChart.Series[0];
            series.ChartType = type;
            series.Color = Color.Black;
            series.BorderWidth = 6;
            series.LegendText = "Felhasznált bőr (\u33A1)";

            DataPointCollection points = series.Points;
            //points.AddXY("Kis János", 79);
            //points.AddXY("Nagy Béla", 67);
            //points.AddXY("Molnár Bence", 13);

            points.Clear();
            for (int i = 0; i < data.Count; i++)
            {
                //points.AddXY(i + 1, data[i]);
                DataPoint p = new DataPoint();
                p.SetValueXY(i + 1, data[i]);
                p.ToolTip = data[i].ToString();
                //p.Color = Color.FromArgb((int)(data[i] / 100.0 * 255), 0, 0);
                points.Add(p);
            }

            // Diagramterület formázása
            ChartArea area = DataChart.ChartAreas[0];

            area.AxisX.Title = "Nap";

            area.AxisY.Title = "Felhasznált bőr (\u33A1)";
            //area.AxisY.Minimum = data.Min() - 10;
            //area.AxisY.Maximum = data.Max() + 10;
            //area.AxisY.Interval = 10;
            area.AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
        }
    }
}
