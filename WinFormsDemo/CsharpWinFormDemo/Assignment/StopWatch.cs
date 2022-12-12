using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpWinFormDemo.Assignment
{
    public partial class StopWatch : Form
    {
        int Hour = 0, Min = 0, Sec = 0, MilliSec = 0;
        string dHour = "00", dMin = "00", dSec = "00", dMilliSec = "00";

        public StopWatch()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayTime();
        }

        private void DisplayTime()
        {
            if (MilliSec < 10)
            {
                dMilliSec = "0" + MilliSec;
            }
            else
            {
                dMilliSec = MilliSec.ToString();
            }

            if (Sec < 10)
            {
                dSec = "0" + Sec;
            }
            else
            {
                dSec = Sec.ToString();
            }

            if (Min < 10)
            {
                dMin = "0" + Min;
            }
            else
            {
                dMin = Min.ToString();
            }

            if (Hour < 10)
            {
                dHour = "0" + Hour;
            }
            else
            {
                dHour = Hour.ToString();
            }

            LblTimer.Text = $"{dHour} : {dMin} : {dSec} : {dMilliSec}";
            MilliSec ++;
            //Sec++;

            if (MilliSec >= 59)
            {
                Sec++;
                MilliSec = 0;
            }

            if(Sec >= 59)
            {
                Min++;
                Sec = 0;
            }

            if(Min >= 59)
            {
                Hour++;
                Min = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
