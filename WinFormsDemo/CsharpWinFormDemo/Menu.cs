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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Clicked");
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(toolStripComboBox1.Text);
        }

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(toolStripComboBox1.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toolbar Button clicked");
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter Your Name";
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
    }
}
