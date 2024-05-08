using EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ucSchedule : UserControl
    {
        // Person whose events are displayed
        Person person = null;
        List<Job> jobOfWorker = new List<Job>();

        // Display schedule of worker for hirer or not
        bool isForHirer;

        // Fetch data from database
        DAO.DbConnection dbConn = new DAO.DbConnection();   

        // Store current time that display on the calendar
        DateTime currentTimeInCalendar = DateTime.Now;

        // Day list on schedule
        List<ucDay> dayList = new List<ucDay>();    

        public ucSchedule()
        {
            InitializeComponent();
        }

        // Display event of a person onto schedule
        public ucSchedule(Person person, bool isHirer)
        {
            InitializeComponent();
            this.person = person;
            this.isForHirer = isHirer;

            // Fetch job data
            jobOfWorker = dbConn.FetchJobList(person, true);

            // Display day onto calendar
            DisplayDays(currentTimeInCalendar);

            // Display guide image
            DisplayGuideImage();
        }

        // Display all days of a specific month
        private void DisplayDays(DateTime now)
        {
            // Clear all current days (if has)
            fpnlDayContainer.Controls.Clear();
            dayList.Clear();

            // Get amount of days in month
            int amountDayInMonth = DateTime.DaysInMonth(now.Year, now.Month);
            // Get 1st day of the month
            DateTime firstDayOfMonth = new DateTime(now.Year, now.Month, 1);
            // Get day in week of 1st day of month
            int dayOfWeek = Convert.ToInt32(firstDayOfMonth.DayOfWeek.ToString("d")) + 1;

            // Display month and year
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(now.Month);
            lblYearAndMonth.Text = monthName + " " + now.Year.ToString("d");

            // Ignore days in previous month
            for (int i = 1; i < dayOfWeek; i++)
            {
                ucDay day = new ucDay(now, isForHirer);
                day.Blank();
                fpnlDayContainer.Controls.Add(day);
            }

            // Display days in input month
            for (int i = 1; i <= amountDayInMonth; i++)
            { 
                ucDay day = new ucDay(now, isForHirer);
                day.Day(i);

                // Check for today 
                if (now.Month == DateTime.Now.Month && i == DateTime.Now.Day && now.Year == DateTime.Now.Year)
                {
                    day.Highlight();
                }

                // Add day to container and day list
                fpnlDayContainer.Controls.Add(day);
                dayList.Add(day);
            }

            // Map event
            MapEvent();
        }

        /// <summary>
        /// Map job event onto day
        /// </summary>
        private void MapEvent()
        {
            // Filter job in current month
            List<Job> currentMonthJob = jobOfWorker.Where(x => 
            (x.Date.Month == currentTimeInCalendar.Month 
            && x.Date.Year == currentTimeInCalendar.Year
            && x.IsAccepted == true)).ToList();
            
            foreach (Job job in currentMonthJob) 
            {
                dayList[job.Date.Day - 1].AddEvent(job, isForHirer);
            }
        }

        // Redisplay calendar by previous month
        private void picPreviousMonth_Click(object sender, EventArgs e)
        {
            // Add 1 month to current time
            currentTimeInCalendar = currentTimeInCalendar.AddMonths(-1);
            DisplayDays(currentTimeInCalendar);
        }

        // Redisplay calendar by next month
        private void picNextMonth_Click(object sender, EventArgs e)
        {
            // Subtract 1 month to current time
            currentTimeInCalendar = currentTimeInCalendar.AddMonths(1);
            DisplayDays(currentTimeInCalendar);
        }

        // Set color for ucEvent, which is used for help user identify events
        private void DisplayGuideImage()
        {
            ucEventCancel.Cancel();
            ucEventDone.Done();
            ucEventEvaluated.Evaluated();
            ucEventIncoming.Incoming();
        }
    }
}
