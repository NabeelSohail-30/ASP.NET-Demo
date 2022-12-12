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
    public partial class FormDialog : Form
    {
        public FormDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = folderBrowserDialog1.ShowDialog();

            if(dr == DialogResult.OK)
            {
                this.textBox1.Text = this.folderBrowserDialog1.SelectedPath;
            }
            else
            {
                this.textBox1.Text = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Multiselect = true;

            //Initial Directory
            of.InitialDirectory = @"C:\";

            //Title
            of.Title = "Please select File(s)";

            //Default Extension(s)
            //of.DefaultExt = "txt";

            //Filter and FilterIndex
            of.Filter = "All Graphics Files|*.png;*.jpg;*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|JPEG|*.JPEG";
            of.FilterIndex = 2;

            //CheckFileExists - ByDefaykt True
            of.CheckFileExists = false;
            //CheckPathExists

            //ReadOnlyChecked
            //of.ReadOnlyChecked = true;
            of.ShowReadOnly = true;

            if(of.ShowDialog()==DialogResult.OK)
            {
                //FileName Property will return the 1st Selected File with complete Path.
                textBox2.Text = of.FileName;
                this.checkBox1.Checked = of.ReadOnlyChecked;
                //FileNames Property will return the multiple selected files as a Collection
                //StringBuilder sb = new StringBuilder();
                textBox3.Lines = of.FileNames;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.ShowDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = saveFileDialog1.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            //colorDialog1.ShowDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox5.Text = colorDialog1.Color.Name;
                Color selectedColor = colorDialog1.Color;

                textBox5.BackColor = selectedColor;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox6.Text = "New Font";

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Font selectedFont = fontDialog1.Font;
                Color selectedColor = fontDialog1.Color;

                textBox6.Font = selectedFont;
                textBox6.ForeColor = selectedColor;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 5;
            label1.Text = progressBar1.Value.ToString() + "%";
        }

        private void FormDialog_Load(object sender, EventArgs e)
        {
            DisplayCurrentTime();
            label3.Text = "0";
        }

        private void DisplayCurrentTime()
        {
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCurrentTime();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label3.Text = (int.Parse(label3.Text) + 1).ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }
    }
}
