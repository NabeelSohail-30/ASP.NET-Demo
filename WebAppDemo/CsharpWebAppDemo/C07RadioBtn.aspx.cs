using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class C07RadioBtn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                Response.Write("Gender = Male");
            }
            else if(RadioButton2.Checked)
            {
                Response.Write("Gender = Female");
            }
            else if (RadioButton3.Checked)
            {
                Response.Write("Gender = Others");
            }
            else
            {
                Response.Write("No Button Checked");
            }

            GetRadioListVal();
        }

        private void GetRadioListVal()
        {
            Response.Write($"<br>Selected = {RadioButtonList1.SelectedItem}");
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write($"Pre Checked = {RadioButton1.Checked}");
            
        }
    }
}