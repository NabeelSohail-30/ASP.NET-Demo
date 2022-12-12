using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            float Num01;
            float Num02;

            float.TryParse(TxtNum01.Text, out Num01);
            float.TryParse(TxtNum02.Text, out Num02);

            TxtResult.Text = (Num01+Num02).ToString();
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            float Num01;
            float Num02;

            float.TryParse(TxtNum01.Text, out Num01);
            float.TryParse(TxtNum02.Text, out Num02);

            TxtResult.Text = (Num02 - Num01).ToString();
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            float Num01;
            float Num02;

            float.TryParse(TxtNum01.Text, out Num01);
            float.TryParse(TxtNum02.Text, out Num02);

            TxtResult.Text = (Num01 * Num02).ToString();
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            float Num01;
            float Num02;

            float.TryParse(TxtNum01.Text, out Num01);
            float.TryParse(TxtNum02.Text, out Num02);

            TxtResult.Text = (Num01 / Num02).ToString();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtNum01.Text = null;
            TxtNum02.Text = null;
            TxtResult.Text = null;
        }
    }
}
