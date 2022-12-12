using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpWinFormDemo
{
    class MyStopWatch
    {
        Timer MyTimer;
        
        private int Hour = 0, Min = 0, Sec = 0, MilliSec = 0;
        private string dHour = "00", dMin = "00", dSec = "00", dMilliSec = "00";
        public MyStopWatch()
        {
            MyTimer = new Timer();
            MyTimer.Interval = 1;
            MyTimer.Tick += MyTimer_Tick;
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            this.Start();

        }

        public string Start()
        {
            MyTimer.Enabled = true;

            string DisplayTime;

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

            DisplayTime = $"{dHour} : {dMin} : {dSec} : {dMilliSec}";
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

            return DisplayTime;
        }

        public void Stop()
        {
            MyTimer.Enabled = false;
        }
    }
}
