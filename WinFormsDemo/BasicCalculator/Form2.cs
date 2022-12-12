using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicCalculator.Model;

namespace BasicCalculator
{
    
    public partial class Form2 : Form
    {
        float n1, n2;
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.LblLastResult.Text = $"Last Result: {Calculator.GetResult()}";
            ParseFormValues();

            this.TxtResult.Text = (Calculator.Sum(n1, n2)).ToString();
            this.LblHistory.Text = Calculator.ResultHistories();
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            this.LblLastResult.Text = $"Last Result: {Calculator.GetResult()}";

            ParseFormValues();

            this.TxtResult.Text = (Calculator.Difference(n1, n2)).ToString();
            //this.LblHistory.Lines = (Calculator.ResultHistory().ToArray()).ToString();

        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            this.LblLastResult.Text = $"Last Result: {Calculator.GetResult()}";

            ParseFormValues();

            this.TxtResult.Text = (Calculator.Product(n1, n2)).ToString();
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                this.LblLastResult.Text = $"Last Result: {Calculator.GetResult()}";

                ParseFormValues();

                this.TxtResult.Text = (Calculator.Divide(n1, n2)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.TxtNum02.BackColor = System.Drawing.Color.Red;

                this.TxtNum02.Focus();
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            this.LblLastResult.Text = $"Last Result: {Calculator.GetResult()}";

            this.TxtNum01.Text = null;
            this.TxtNum02.Text = null;
            this.TxtResult.Text = null;
        }

        private void ParseFormValues()
        {
            n1 = float.Parse(this.TxtNum01.Text);
            n2 = float.Parse(this.TxtNum02.Text);
        }
    }
}
