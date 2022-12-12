using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpWinFormDemo
{
    public partial class EnviromentMethods : Form
    {
        public EnviromentMethods()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Environment.CommandLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Environment.CurrentDirectory;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = Environment.CurrentManagedThreadId.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = Environment.ExitCode.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = Environment.HasShutdownStarted.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = Environment.Is64BitOperatingSystem.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = Environment.Is64BitProcess.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = Environment.MachineName.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = Environment.NewLine;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = Environment.OSVersion.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = Environment.ProcessorCount.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = Environment.StackTrace;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = Environment.SystemDirectory;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = Environment.SystemPageSize.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = Environment.TickCount.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = Environment.UserDomainName;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = Environment.UserInteractive.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = Environment.UserName;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = Environment.Version.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = Environment.WorkingSet.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //Environment.Exit();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //textBox1.Text = Environment.ExpandEnvironmentVariables();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //textBox1.Text = Environment.FailFast();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Lines = Environment.GetCommandLineArgs();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //textBox1.Text = Environment.GetEnvironmentVariable();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //textBox1.Text = Environment.GetEnvironmentVariable();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //textBox1.Text = Environment.GetEnvironmentVariables();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //textBox1.Text = Environment.GetEnvironmentVariables();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            //textBox1.Text = Environment.GetFolderPath();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            //textBox1.Text = Environment.GetFolderPath();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox1.Lines = Environment.GetLogicalDrives();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            //textBox1.Text = Environment.SetEnvironmentVariable();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            //textBox1.Text = Environment.SetEnvironmentVariable();
        }
    }
}
