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
    public partial class Form5RadioBtn : Form
    {
        public Form5RadioBtn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RDGenderMale.Checked)
            {
                MessageBox.Show(RDGenderMale.Text);
            }
            else if(RDGenderFemale.Checked)
            {
                MessageBox.Show(RDGenderFemale.Text);
            }
            else if (RDGenderOthers.Checked)
            {
                MessageBox.Show(RDGenderOthers.Text);
            }
        }

        private void RDGenderFemale_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(RDGenderFemale.Checked.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox1.Text = checkBox1.CheckState.ToString();

            switch(checkBox1.CheckState)
            {
                case CheckState.Checked:
                {
                    textBox1.Text = checkBox1.CheckState.ToString();
                    break;
                }

                case CheckState.Unchecked:
                {
                        textBox1.Text = checkBox1.CheckState.ToString();
                        break;
                }

                case CheckState.Indeterminate:
                {
                        textBox1.Text = checkBox1.CheckState.ToString();
                        break;
                }
            }

            if (checkBox1.CheckState == CheckState.Checked)
            {
                MessageBox.Show(checkBox1.Text);
            }

            if (checkBox2.Checked)
            {
                MessageBox.Show(checkBox2.Text);
            }

            if (checkBox3.Checked)
            {
                MessageBox.Show(checkBox3.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap MyImage = new Bitmap(@"E:\Programming-Web-DB\DotNet\Images\img1.jpeg");
            this.pictureBox1.Image = MyImage;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Image.FromFile(@"E:\Programming-Web-DB\DotNet\Images\img2.jpeg");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateTime myDt = dateTimePicker1.Value;

            MessageBox.Show(myDt.ToString());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString("dd-MMMM-yyyy, dddd"));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(maskedTextBox1.MaskFull.ToString());
            
        }
    }
}
