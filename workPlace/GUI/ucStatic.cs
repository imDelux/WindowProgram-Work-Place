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

        private void btnLastweek_Click(object sender, EventArgs e)
        {
            // biểu đồ cột
            List<double> wagesList = new List<double>();

            // Add some sample data to wagesList (you would replace this with your actual data)
            wagesList.Add(100.50); // Example wage for day 1
            wagesList.Add(150.75); // Example wage for day 2
            wagesList.Add(200.25); // Example wage for day 3
                                   // Add more sample data as needed

            // Create a new series
            Series series = new Series();
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

            // biểu đồ tròn 
            List<string> jobTypesList = new List<string>();

            // Add some sample data to jobTypesList (you would replace this with your actual data)
            jobTypesList.Add("Type A"); // Example job type for worker
            jobTypesList.Add("Type A");
            jobTypesList.Add("Type B");
            jobTypesList.Add("Type C");
            jobTypesList.Add("Type B");
            // Add more sample data as needed

            // Count occurrences of each job type
            Dictionary<string, int> jobTypeCounts = new Dictionary<string, int>();
            foreach (string jobType in jobTypesList)
            {
                if (jobTypeCounts.ContainsKey(jobType))
                {
                    jobTypeCounts[jobType]++;
                }
                else
                {
                    jobTypeCounts[jobType] = 1;
                }
            }

            // Create a new series
            Series series2 = new Series();
            series2.ChartType = SeriesChartType.Pie;
            series2.Name = "Job Type Counts"; // Name your series

            // Add data points to the series for each job type count
            foreach (var kvp in jobTypeCounts)
            {
                series2.Points.AddXY(kvp.Key, kvp.Value);
            }

            // Add the series to the chart
            cJob.Series.Add(series2);

            // Set chart title and axis labels if needed
            cJob.Titles.Add("Job Type Counts Chart");
            cJob.ChartAreas[0].AxisX.Title = "Job Type";
            cJob.ChartAreas[0].AxisY.Title = "Count";
        }

        private void btnLastmonth_Click(object sender, EventArgs e)
        {

        }
    }
}
