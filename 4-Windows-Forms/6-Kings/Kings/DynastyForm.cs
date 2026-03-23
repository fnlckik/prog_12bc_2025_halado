using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Kings
{
    public partial class DynastyForm : Form
    {
        private Dictionary<string, int> freq;

        public DynastyForm(Dictionary<string, int> freq)
        {
            InitializeComponent();
            this.freq = freq;
        }

        private void DynastyForm_Load(object sender, EventArgs e)
        {
            Series series = Chart.Series[0];
            series.ChartType = SeriesChartType.Column;
            series.IsVisibleInLegend = false;
            foreach (string dynasty in freq.Keys)
            {
                DataPoint p = new DataPoint();
                p.SetValueXY(dynasty, freq[dynasty]);
                p.ToolTip = $"{freq[dynasty]} fő";
                series.Points.Add(p);
            }
            Chart.ChartAreas[0].AxisX.Interval = 1;
        }
    }
}
