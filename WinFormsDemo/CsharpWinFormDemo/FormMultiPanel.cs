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
    public partial class FormMultiPanel : Form
    {
        public FormMultiPanel()
        {
            InitializeComponent();
        }

        private void FormMultiPanel_Load(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(panel1.Visible==true)
            {
                this.panel1.Visible = false;
                this.panel3.Visible = false;
                this.panel2.Visible = true;
                this.panel2.BringToFront();
            }
        }
    }
}
