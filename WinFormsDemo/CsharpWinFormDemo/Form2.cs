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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show((this.numericUpDown1.Value).ToString());
            MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show($"Key Down Fired, {textBox1.TextLength}");
            // MessageBox.Show($"{((TextBox)sender).Text}"); //this.textBox1

            //MessageBox.Show(e.KeyCode.ToString());
            //if (e.KeyCode != Keys.F)
            //    MessageBox.Show("Invalid Key");
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == Keys.F.ToString())
            {
                MessageBox.Show("Valid Value");
            }
            else
            {
                MessageBox.Show("Invalid Value");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            //MessageBox.Show(e.KeyChar.ToString());
            //e.Handled = false;
            //e.Handled = (e.KeyChar >= 'a' && e.KeyChar <='z') ? false : true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.textBox3.AutoCompleteCustomSource.Clear();
            this.textBox3.AutoCompleteCustomSource.AddRange(new string[] {
            "Red",
            "Yellow",
            "Green",
            "White",
            "Black",
            "Blue",
            "Orange",
            "Black Gray"});
            this.textBox3.AutoCompleteCustomSource.Add("Sohail");
            this.textBox3.AutoCompleteCustomSource.Add("Sky Blue");

            List<string> MyList = new List<string>();
            MyList.Add("Barbar");
            MyList.Add("Lion");
            MyList.Add("Nabeel");

            this.textBox3.AutoCompleteCustomSource.AddRange(MyList.ToArray());
            
            this.textBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            //this.textBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
        }
    }
}
