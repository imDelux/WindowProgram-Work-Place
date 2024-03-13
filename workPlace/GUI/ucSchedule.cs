using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        // Store current time that display on the calendar
        DateTime currentTimeInCalendar = DateTime.Now;

        public ucSchedule()
        {
            InitializeComponent();
        }

        // Load calendar
        private void usSchedule_Load(object sender, EventArgs e)
        {
            DisplayDays(currentTimeInCalendar);
        }

        // Display all days of a specific month
        private void DisplayDays(DateTime now)
        {
            // Clear all current days (if has)
            fpnlDayContainer.Controls.Clear();

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
                ucDay day = new ucDay();
                day.Blank();
                fpnlDayContainer.Controls.Add(day);
            }

            // Display days in input month
            for (int i = 1; i <= amountDayInMonth; i++) 
            {
                ucDay day = new ucDay();
                day.Day(i);
                fpnlDayContainer.Controls.Add(day);
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
    }
}
