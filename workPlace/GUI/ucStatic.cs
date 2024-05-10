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
        Series seriesWage = new Series();
        //Series seriesDonut = new Series();

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
            cWage.Series.Add(seriesWage);
            seriesWage.ChartType = SeriesChartType.Column;
            seriesWage.Name = "Wages"; // Name your series
            cWage.ChartAreas[0].AxisY.Title = "Wage";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="wagesList"></param>
        /// <param name="isForMonth">Month or Year</param>
        public void DisplayLineChart(List<int> wagesList, bool isForMonth)
        {
            seriesWage.Points.Clear();
            // Loop through the list of wages and add data points to the series
            for (int i = 0; i < wagesList.Count; i++)
            {
                seriesWage.Points.AddXY("", wagesList[i]);
            }
            cWage.ChartAreas[0].AxisX.Title = isForMonth ? "Day" : "Month";
        }

        private void DisplayDonutPieChart(int doneJob, int cancelJob)
        {
            // Calculate the percentage of done jobs
            double donePercent = (double)doneJob / (doneJob + cancelJob) * 100;
            double cancelPercent = 100 - donePercent;

            // Create the chart
            cJob.Series["Series1"].Points.Clear();
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
            List<int> wage = new List<int>();
            int jobDone, jobCancel;

            if (isMonth)
            {
                wage = jobDAO.WageOfMonth(currentTime, currentUsingWorker);
                jobDone = jobDAO.NumbJobDoneOfMonth(currentTime, currentUsingWorker);
                jobCancel = jobDAO.NumbJobCancelOfMonth(currentTime, currentUsingWorker);
            }
            else
            {
                wage = jobDAO.WageOfYear(currentTime, currentUsingWorker);
                jobDone = jobDAO.NumbJobDoneOfYear(currentTime, currentUsingWorker);
                jobCancel = jobDAO.NumbJobCancelOfYear(currentTime, currentUsingWorker);
            }

            // Chart
            DisplayLineChart(wage, isMonth);
            DisplayDonutPieChart(jobDone, jobCancel);

            // Total calculate
            lblTotalJob.Text = (jobDone + jobCancel).ToString();

            int totalProfit = 0;
            foreach (int i in wage)
            {
                totalProfit += i;
            }
            lblProfit.Text = totalProfit.ToString() + "$";

            // Time
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
            if (isMonth)
            {
                currentTime = currentTime.AddMonths(-1);
            }
            else
            {
                currentTime = currentTime.AddYears(-1);
            }
            SetData();
        }

        private void picNextMonth_Click(object sender, EventArgs e)
        {
            if (isMonth)
            {
                currentTime = currentTime.AddMonths(1);
            }
            else
            {
                currentTime = currentTime.AddYears(1);
            }
            SetData();
        }
    }
}
