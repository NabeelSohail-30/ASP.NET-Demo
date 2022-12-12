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
    public partial class FormDynamicControl : Form
    {
        //int YAxis = 100;
        TextBox TxtBox;
        public FormDynamicControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label Lbl01 = new Label();
            Lbl01.Name = "Label01";
            Lbl01.Text = "Student Name 01";
            Lbl01.Location = new Point(100, 100);
            Lbl01.AutoSize = true;
            this.Controls.Add(Lbl01);

            TxtBox = new TextBox();
            TxtBox.Name = "TextBox01";
            TxtBox.Location = new Point(100, 120);
            TxtBox.Size = new Size(200, 20);
            Font MyTxtFont = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TxtBox.Font = MyTxtFont;
            this.Controls.Add(TxtBox);

            Button Btn01 = new Button();
            Btn01.Name = "Button01";
            Btn01.Text = "Submit";
            Btn01.Size = new Size(80, 80);
            Btn01.Location = new Point(100, 150);
            this.Controls.Add(Btn01);

            Btn01.Click += Btn01_Click;

            TextBox TxtBox2 = new TextBox();
            TxtBox2.Name = "TextBox02";
            TxtBox2.Location = new Point(350, 120);
            TxtBox2.Size = new Size(200, 20);
            //Font MyTxtFont = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TxtBox2.Font = MyTxtFont;
            this.Controls.Add(TxtBox2);

            //YAxis += 20;
        }

        private void Btn01_Click(object sender, EventArgs e)
        {
            Control myCtrl = this.Controls["TextBox02"];

            // By Using Type Casting
            TextBox myCtrl2 = (TextBox)(this.Controls["TextBox02"]); 
            
            MessageBox.Show("Text Control 1 = " + TxtBox.Text);
            MessageBox.Show("Text Control 2 = " + myCtrl.Text);
            MessageBox.Show("Text Control 2 = " + myCtrl2.Text);
            MessageBox.Show("Text Control 2 = " + ((TextBox)(this.Controls["TextBox02"])).Text);

        }
    }
}
