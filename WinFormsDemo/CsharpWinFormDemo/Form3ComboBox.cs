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
    public partial class Form3ComboBox : Form
    {
        public Form3ComboBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.comboBox1.Items.Clear();
            this.comboBox1.Items.Add("Nabeel");
            this.comboBox1.Items.Add("Sohail");
            this.comboBox1.Items.Add("Jasim");
            this.comboBox1.Items.AddRange(new object[] {
                                                        "Ali",
                                                        "Ahmed",
                                                        "Raheel",
                                                        "Ahmed Abdullah",
                                                        "Abdul Habib"
                                                        });
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.comboBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show((this.comboBox1.Items.Count).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach(string i in this.comboBox1.Items)
            {
                textBox1.Text = textBox1.Text + i + Environment.NewLine;
                //textBox1.Text = Environment.NewLine;
            }

            StringBuilder sb = new StringBuilder();

            for(int i=0;i<(this.comboBox1.Items.Count);i++)
            {
                sb.Append(this.comboBox1.Items[i]);
                sb.Append("\r\n");
            }
            textBox2.Text = sb.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Text = "Sohailahmed";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox1.Focus();
            MessageBox.Show(comboBox1.SelectedText);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1.Focus();
            //MessageBox.Show(comboBox1.SelectedText);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedIndex.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //int Index = comboBox1.SelectedIndex;
            if (comboBox1.SelectedIndex != -1)
                MessageBox.Show(comboBox1.Items[comboBox1.SelectedIndex].ToString());
            //var returnval = (comboBox1.SelectedIndex != -1) ? MessageBox.Show(comboBox1.Items[comboBox1.SelectedIndex].ToString()) : false;
            //ComboBox
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show((comboBox1.SelectedItem).ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Logic 01
            //comboBox1.SelectedIndex = -1;
            //comboBox1.SelectedItem = textBox3.Text;
            //if (comboBox1.SelectedIndex != -1)
            //{
            //    MessageBox.Show(comboBox1.SelectedIndex.ToString());
            //}
            //else
            //{
            //    MessageBox.Show("Not Found");
            //}

            //Logic 2 - Check all the Items and Compare
            //comboBox1.SelectedIndex = -1;
            //foreach (string i in this.comboBox1.Items)
            //{
            //    if(textBox3.Text.ToUpper() == i.ToUpper())
            //    {
            //        comboBox1.SelectedItem = i;
            //        break;
            //    }
            //}

            //if (comboBox1.SelectedIndex != -1)
            //{
            //    MessageBox.Show(comboBox1.SelectedIndex.ToString());
            //}
            //else
            //{
            //    MessageBox.Show("Not Found");
            //}

            //Logic 3 - Check all the Items and Compare using for counter but not exact match (Starts wtih)
            
            int i;
            bool found = false;
            int strLen = textBox3.Text.Length ;

            for(i=0;i<comboBox1.Items.Count;i++)
            {
                //soh == sohail
                if (textBox3.Text.ToUpper() == (comboBox1.Items[i].ToString().ToUpper()).Substring(0,strLen))
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                MessageBox.Show(i.ToString());
            }
            else
            {
                MessageBox.Show("Not Found");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.FindString(textBox3.Text).ToString());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            comboBox2.ValueMember = "Id";
            //comboBox2.DisplayMember = "Text"; // Property
            comboBox2.DisplayMember = "GetFullNationality"; //Prop

            Nationality N1 = new Nationality(101, "Pakistani");
            Nationality N2 = new Nationality(102, "American");
            Nationality N3 = new Nationality(103, "Canadian");
            Nationality N4 = new Nationality(104, "British");
            Nationality N5 = new Nationality(105, "Kuwaiti");
            Nationality N6 = new Nationality(106, "Turkish");

            comboBox2.Items.Add(N1);
            comboBox2.Items.Add(N2);
            comboBox2.Items.Add(N3);
            comboBox2.Items.Add(N4);
            comboBox2.Items.Add(N5);
            comboBox2.Items.Add(N6);

            List<Nationality> NList = new List<Nationality>();
            NList.Add(new Nationality(107, "Indian"));
            NList.Add(new Nationality(108, "African"));
            NList.Add(new Nationality(109, "Irani"));
            NList.Add(new Nationality(110, "Saudi"));
            
            foreach(Nationality list in NList)
                comboBox2.Items.Add(list);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < (this.comboBox2.Items.Count); i++)
            {
                //Nationality n = (Nationality)(this.comboBox2.Items[i]);

                //sb.Append(n.Id + " - " + n.Text);
                sb.Append(((Nationality)(this.comboBox2.Items[i])).Text);
                sb.Append("\r\n");
            }
            textBox4.Text = sb.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Nationality n = (Nationality)(this.comboBox2.SelectedItem);
            //((Nationality)(this.comboBox2.SelectedItem)).
            MessageBox.Show(n.Id.ToString());
            MessageBox.Show(((Nationality)(this.comboBox2.SelectedItem)).Text);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.comboBox2.Text);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.comboBox2.SelectedText);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show((this.comboBox2.SelectedIndex).ToString());
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.comboBox2.SelectedIndex = 3;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.comboBox2.SelectedIndex = -1;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            MessageBox.Show((this.comboBox2.FindStringExact(textBox5.Text)).ToString());
        }

        private void Form3ComboBox_Load(object sender, EventArgs e)
        {

        }
    }
    public class Nationality
{
    public Nationality(int _Id, string _Text)
    {
        this.Id = _Id;
        this.Text = _Text;
    }

    public int Id { get; set; }
    public string Text { get; set; }

    public string GetFullNationality
    {
        get
        {
            return $"{this.Id} - {this.Text}";
        }
    }
} 
}
