using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rejestracja2
{
    public partial class UcCalendar : UserControl
    {
        private int currentYear = DateTime.Now.Year;
        private int currentMonth = DateTime.Now.Month;

        public UcCalendar()
        {
            InitializeComponent();
            RefreshCalendar();
        }

        private void RefreshCalendar()
        {
            DateTime displayDate = new DateTime(currentYear, currentMonth, 1);
            string monthName = displayDate.ToString("MMMM yyyy", new System.Globalization.CultureInfo("pl-PL"));

            lblMonthYear.Text = char.ToUpper(monthName[0]) + monthName.Substring(1);

            BuildCalendar(currentYear, currentMonth);
        }

        private void BuildCalendar(int year, int month)
        {
            dataGridViewCalendar.Columns.Clear();
            dataGridViewCalendar.Rows.Clear();
            dataGridViewCalendar.AllowUserToAddRows = false;
            dataGridViewCalendar.ReadOnly = true;
            dataGridViewCalendar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCalendar.RowHeadersVisible = false;

            dataGridViewCalendar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCalendar.DefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);

            string[] days = { "PN", "WT", "ŚR", "CZW", "PT", "SOB", "NDZ" };

            foreach (string day in days)
            {
                dataGridViewCalendar.Columns.Add(day, day);
            }

            DateTime firstDayInMonth = new DateTime(year, month, 1);
            int countDaysInMonth = DateTime.DaysInMonth(year, month);

            int starterDayInWeek = (int)firstDayInMonth.DayOfWeek;
            starterDayInWeek = starterDayInWeek == 0 ? 6 : starterDayInWeek - 1;

            int currentRow = dataGridViewCalendar.Rows.Add();

            for (int i = 0; i < starterDayInWeek; i++)
            {
                dataGridViewCalendar.Rows[currentRow].Cells[i].Value = "";
            }

            int curretCell = starterDayInWeek;

            for (int day = 1; day <= countDaysInMonth; day++)
            {
                dataGridViewCalendar.Rows[currentRow].Cells[curretCell].Value = day.ToString();
                curretCell++;

                if (curretCell > 6 && day < countDaysInMonth)
                {
                    curretCell = 0;
                    currentRow = dataGridViewCalendar.Rows.Add();
                }
            }

            foreach (DataGridViewRow row in dataGridViewCalendar.Rows)
            {
                row.Height = 50;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentMonth--;
            if (currentMonth < 1)
            {
                currentMonth = 12;
                currentYear--;
            }
            RefreshCalendar();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentMonth++;
            if (currentMonth > 12)
            {
                currentMonth = 1;
                currentYear++;
            }
            RefreshCalendar();
        }
    }
}
