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

namespace nomico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Series a = new Series();
            a.ChartType = SeriesChartType.Bar;
            a.Points.Add(100);
            a.Points.Add(10);
            a.Points.Add(200);
            chart1.Series.Add(a);
        }
    }
}
