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
    public partial class FormTabControl : Form
    {
        public FormTabControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tabControl1.TabPages[2].ToString());
            tabControl1.SelectedTab = tabControl1.TabPages[2];
        }

        private void FormTabControl_Load(object sender, EventArgs e)
        {
            
        }

        private void TabContact_Click(object sender, EventArgs e)
        {
          
            //MessageBox.Show(this.tabControl1.SelectedIndex.ToString());
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //MessageBox.Show(this.tabControl1.SelectedIndex.ToString());
            if(this.tabControl1.SelectedIndex==3)
            {
                if(string.IsNullOrEmpty(this.textBox3.Text))
                    e.Cancel = true;
            }
        }
    }
}
