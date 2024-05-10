using DAO;
using EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class ucStatic : UserControl
    {
        Worker currentUsingWorker = null;
        bool isMonth = true;
        JobDAO jobDAO = new JobDAO();

        // Time
        DateTime currentTime = DateTime.Now;

        // Series chart
        Series series = new Series();

        public ucStatic()
        {
            InitializeComponent();
        }

        public ucStatic(Worker worker)
        {
            InitializeComponent();
            this.currentUsingWorker = worker;

            // Series chart
            AddChart();

            // Initial display
            SetData();
        }

        public void AddChart()
        {
            cWage.Series.Add(series);
            series.ChartType = SeriesChartType.Column;
            series.Name = "Wages"; // Name your series
            cWage.ChartAreas[0].AxisY.Title = "Wage";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="wagesList"></param>
        /// <param name="isForMonth">Month or Year</param>
        public void DisplayLineChart(List<int> wagesList, bool isForMonth)
        {
            series.Points.Clear();
            // Loop through the list of wages and add data points to the series
            for (int i = 0; i < wagesList.Count; i++)
            {
                series.Points.AddXY("", wagesList[i]);
            }
            cWage.ChartAreas[0].AxisX.Title = isForMonth ? "Day" : "Month";
        }

        private void DisplayDonutPieChart(int doneJob, int cancelJob)
        {
            // Calculate the percentage of done jobs
            double donePercent = (double)doneJob / (doneJob + cancelJob) * 100;
            double cancelPercent = 100 - donePercent;

            // Create the chart
            cJob.Series.Clear();
            cJob.Series["Series1"].Points.AddXY("Done Job", donePercent);
            cJob.Series["Series1"].Points[0].LegendText = "Done Job";
            cJob.Series["Series1"].Points.AddXY("Canceled Job", cancelPercent);
            cJob.Series["Series1"].Points[1].LegendText = "Canceled Job";
            cJob.Series["Series1"].IsVisibleInLegend = true;
            cJob.Series["Series1"].Label = "#PERCENT{P0}";
        }

        /// <summary>
        /// Set time onto form
        /// </summary>
        private void SetTime()
        {
            lblMonth.Text = "Time: " + (currentTime.Month < 10 ? "0" : "") + currentTime.Month.ToString();
            lblYear.Text = "- " + currentTime.Year.ToString();
        }

        private void SetData()
        {
            if (isMonth)
            {
                DisplayLineChart(jobDAO.WageOfMonth(currentTime, currentUsingWorker), true);
                DisplayDonutPieChart(jobDAO.NumbJobDoneOfMonth(currentTime, currentUsingWorker), jobDAO.NumbJobCancelOfMonth(currentTime, currentUsingWorker));
            }
            else
            {
                DisplayLineChart(jobDAO.WageOfYear(currentTime, currentUsingWorker), true);
                DisplayDonutPieChart(jobDAO.NumbJobDoneOfYear(currentTime, currentUsingWorker), jobDAO.NumbJobCancelOfYear(currentTime, currentUsingWorker));
            }
            SetTime();
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            isMonth = true;
            SetData();
        }

        private void btnThisYear_Click(object sender, EventArgs e)
        {
            isMonth = false;
            SetData();
        }

        private void picPreviousMonth_Click(object sender, EventArgs e)
        {

        }

        private void picNextMonth_Click(object sender, EventArgs e)
        {

        }
    }
}
