using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnviromentSummary
{
    public partial class WindowsAndPCDetail : Form
    {
        public WindowsAndPCDetail()
        {
            InitializeComponent();
        }

        private void FormProperties_Load(object sender, EventArgs e)
        {
            //Command Line
            TxtCmdLine.Text = Environment.CommandLine;

            //Current Directory
            TxtCurDir.Text = Environment.CurrentDirectory;

            //Is 64 OS
            if (Environment.Is64BitOperatingSystem)
            {
                TxtOSBit.Text = "64 bit Operating System";
            }
            else
            {
                TxtOSBit.Text = "32 bit Operating System";
            }

            //Is 64bit Processor
            Txt64bitProcessor.Text = Environment.Is64BitProcess.ToString();

            //OS Version
            TxtOSVersion.Text = Environment.OSVersion.ToString();

            //ProcessorCount
            TxtNumProcessor.Text = Environment.ProcessorCount.ToString();

            //SystemDir
            TxtSysDir.Text = Environment.SystemDirectory;

            //System Page Size
            TxtSysPgSize.Text = Environment.SystemPageSize.ToString() + " Bytes";

            //Machine Name
            TxtMachine.Text = Environment.MachineName;

            //User Name
            TxtUserName.Text = Environment.UserName;

            //Domain Name
            TxtDomain.Text = Environment.UserDomainName;

            //Version
            TxtVersion.Text = Environment.Version.ToString();

            //Working Set
            TxtWorkingSet.Text = Environment.WorkingSet.ToString();

            //Stack Trace
            TxtStack.Text = Environment.StackTrace;

            //Current Managed Thread Id
            TxtCurThreadId.Text = Environment.CurrentManagedThreadId.ToString();

            //Exit Code
            TxtExitCode.Text = Environment.ExitCode.ToString();

            //Shutdown Started
            TxtHasShutDown.Text = Environment.HasShutdownStarted.ToString();

            //User Interactive
            TxtUserInteractive.Text = Environment.UserInteractive.ToString();

            //Tick Count
            TxtTickCount.Text = Environment.TickCount.ToString();
        }

        private void BtnExit1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnFolder_Click(object sender, EventArgs e)
        {
            this.Hide();

            FolderAndDrivesDetail FormFD = new FolderAndDrivesDetail();
            FormFD.Show();

            
        }
    }
}
