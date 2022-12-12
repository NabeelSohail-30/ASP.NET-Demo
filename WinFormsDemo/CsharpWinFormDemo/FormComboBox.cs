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
    public partial class FormComboBox : Form
    {
        public FormComboBox()
        {
            InitializeComponent();
        }

        private void FormComboBox_Load(object sender, EventArgs e)
        {
            InitializeCombo1();

        }

        private void InitializeCombo1()
        {
            string[] Arr1 = {
                            "Nabeel",
                            "Sohail",
                            "Raheel",
                            "Faisal",
                            "Ahmed",
                            "Shoaib",
                            "Shahrukh",
                            "Saif"
                          };
            comboBox1.Items.AddRange(Arr1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add All
            comboBox2.Items.Clear();
            foreach (string i in this.comboBox1.Items)
            {
                comboBox2.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem != null)
                comboBox2.Items.Add(comboBox1.SelectedItem);
        }
    }
}
