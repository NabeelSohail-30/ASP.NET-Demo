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
    public partial class Form4ListBox : Form
    {
        public Form4ListBox()
        {
            InitializeComponent();
        }

        private void Form4ListBox_Load(object sender, EventArgs e)
        {
            //Adding Items in List Box
            string[] ListCountry = {"Pakistan",
                                    "India",
                                    "Afghanistan",
                                    "Kuwait",
                                    "Turkey",
                                    "Germany",
                                    "Canada",
                                    "England",
                                    "Switzerland"
                                    };

            listBox1.Items.AddRange(ListCountry);
            //End
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.Items.Count.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> arr = new List<string>();

            foreach(string str in listBox1.Items)
            {
                arr.Add(str);
            }

            textBox1.Lines = arr.ToArray();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Text = "Kuwait";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Text = "Afghanistan";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedIndex.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 3;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.FindStringExact(textBox3.Text).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //listBox1.SelectionMode = SelectionMode.MultiExtended;

            //listBox1.Items - Collection of All Items in the ListBox
            //listbox1.SelectedItems - Collection of Selected Items in the ListBox

            this.textBox1.Text = string.Empty;
            foreach(string selItem in  listBox1.SelectedItems)
            {
                this.textBox1.Text += selItem;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            foreach (int SelIndex in listBox1.SelectedIndices)
            {
                this.textBox1.Text += SelIndex;
                this.textBox1.Text += this.listBox1.Items[SelIndex].ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            listBox1.SetSelected(0, true);
            listBox1.SetSelected(4, true);
            listBox1.SetSelected(7, true);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            listBox1.SetSelected(0, false);
            listBox1.SetSelected(4, false);
            listBox1.SetSelected(7, false);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
            for(int i=0;i<listBox1.Items.Count;i++)
            {
                listBox1.SetSelected(i, true);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox2.ValueMember = "Id";
            listBox2.DisplayMember = "GetFullNationality";

            List<Nationality> ListNationality = new List<Nationality>();
            ListNationality.Add(new Nationality(0, "Afghani"));
            ListNationality.Add(new Nationality(1, "Pakistani"));
            ListNationality.Add(new Nationality(2, "English"));
            ListNationality.Add(new Nationality(3, "Austrailian"));
            ListNationality.Add(new Nationality(4, "American"));
            ListNationality.Add(new Nationality(5, "African"));

            foreach(Nationality listN in ListNationality)
            listBox2.Items.Add(listN);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            List<string> arr = new List<string>();

            for(int i=0;i<(this.listBox2.Items.Count);i++)
            {
                arr.Add(((Nationality)(listBox2.Items[i])).GetFullNationality);
            }

            textBox4.Lines = arr.ToArray();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Nationality)(listBox2.SelectedItem)).GetFullNationality);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            List<string> arr = new List<string>();
            this.textBox4.Text = string.Empty;
            foreach (Nationality selected in listBox2.SelectedItems)
            {
                arr.Add(((Nationality)(selected)).GetFullNationality);
            }

            textBox4.Lines = arr.ToArray();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            List<string> arr = new List<string>();
            this.textBox4.Text = string.Empty;
            foreach (int selected in listBox2.SelectedIndices)
            {
                arr.Add(selected.ToString());
                //textBox4.Text += selected + "\r\n";
            }

            textBox4.Lines = arr.ToArray();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox2.SetSelected(i, true);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            listBox2.ClearSelected();
        }
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
