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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int res = Convert.ToInt16(MessageBox.Show("You have clicked Button and I will change the background color now!"));

            this.BackColor = Color.Aqua;
            this.BackgroundImage = null;
            MessageBox.Show(res.ToString());
        }
    }
}
