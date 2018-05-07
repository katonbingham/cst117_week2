using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4
{
    public partial class Form1 : Form
    {
        public static string pDay = "0";
        public static string pHour = "0";
        public static string pMinute = "0";
        public static string pSecond = "0";

        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            
            string junkString = userInput.Text;
            decimal second = Convert.ToDecimal(junkString);
            int day, hour, minute;
            day = hour = minute = 0;

            while (second != 0)
            {
                while (second >= 86400)
                {
                    day++;
                    
                    Decimal.Subtract(second, 86400);
                }
                while (second >= 3600)
                {
                    hour++;
                    Decimal.Subtract(second, 3600);
                }
                while (second >= 60)
                {
                    minute++;
                    Decimal.Subtract(second, 60);
                }

                // now send day, hour, minute, second to display textboxes
                pDay = day.ToString();
                daysElapsed.Text = pDay;
                pHour = hour.ToString();
                hoursElapsed.Text = pHour;
                pMinute = minute.ToString();
                minutesElapsed.Text = pMinute;
                pSecond = second.ToString();
                secondsElapsed.Text = pSecond;
            }
        }

        private void userInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
