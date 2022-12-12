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
    public partial class StopWatch2 : Form
    {
        MyStopWatch StartTimer = new MyStopWatch();

        public StopWatch2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblTimer.Text = StartTimer.Start();
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
            }
            else
            {
                progressBar1.Value = 0;
            }
        }
    }
}
