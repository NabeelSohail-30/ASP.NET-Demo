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
    public partial class FolderAndDrivesDetail : Form
    {
        public FolderAndDrivesDetail()
        {
            InitializeComponent();
        }

        private void FolderAndDrivesDetail_Load(object sender, EventArgs e)
        {
            
            TxtDesktop.Text = Environment.GetFolderPath(0);
            TxtMyDoc.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            TxtFavorites.Text = Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
            TxtDrives.Lines = Environment.GetLogicalDrives();
            TxtMusic.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            TxtVideos.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            //TxtMyComp.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            TxtNetwork.Text = Environment.GetFolderPath(Environment.SpecialFolder.NetworkShortcuts);
            TxtFonts.Text = Environment.GetFolderPath(Environment.SpecialFolder.Fonts);
            TxtInternetCache.Text = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
            TxtCookies.Text = Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
            TxtHistory.Text = Environment.GetFolderPath(Environment.SpecialFolder.History);
            TxtWindows.Text = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
            TxtSystem.Text = Environment.GetFolderPath(Environment.SpecialFolder.System);
            TxtProgramFiles.Text = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            TxtProgramx86.Text = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            TxtSystemx86.Text = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
            TxtMyPic.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            TxtUserProfile.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            TxtResources.Text = Environment.GetFolderPath(Environment.SpecialFolder.Resources);
            TxtRecent.Text = Environment.GetFolderPath(Environment.SpecialFolder.Recent);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();

            WindowsAndPCDetail FormWP = new WindowsAndPCDetail();
            FormWP.Show();
        }
    }
}
