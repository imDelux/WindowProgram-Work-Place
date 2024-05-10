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

namespace GUI
{
    public partial class ucStatic : UserControl
    {
        public ucStatic()
        {
            InitializeComponent();
        }
        public void Chart(List<float> wagesList)
        {
            Series series = new Series();
            series.ChartType = SeriesChartType.Area;
            series.Name = "Daily Wages"; // Name your series

            // Loop through the list of wages and add data points to the series
            for (int i = 0; i < wagesList.Count; i++)
            {
                series.Points.AddXY($"Day {i + 1}", wagesList[i]);
            }
            cWage.Series.Add(series);
            cWage.Titles.Add("Daily Wages Chart");
            cWage.ChartAreas[0].AxisX.Title = "Day";
            cWage.ChartAreas[0].AxisY.Title = "Wage";
        }
        private void DisplayDonutPieChart(int doneJob, int cancelJob)
        {
            // Calculate the percentage of done jobs
            double donePercent = (double)doneJob / (doneJob + cancelJob) * 100;
            double cancelPercent = 100 - donePercent;

            // Create the chart
            cJob.Series["Series1"].Points.AddXY("Done Job", donePercent);
            cJob.Series["Series1"].Points[0].LegendText = "Done Job";
            cJob.Series["Series1"].Points.AddXY("Canceled Job", cancelPercent);
            cJob.Series["Series1"].Points[1].LegendText = "Canceled Job";
            cJob.Series["Series1"].IsVisibleInLegend = true;
            cJob.Series["Series1"].Label = "#PERCENT{P0}";
        }
        private void btnLastweek_Click(object sender, EventArgs e)
        {
            // biểu đồ area


            //Chart(wagesList);


            // biểu đồ tròn 
            //DisplayDonutPieChart(100, 20);
        }

        private void btnLastmonth_Click(object sender, EventArgs e)
        {

        }
    }
}
