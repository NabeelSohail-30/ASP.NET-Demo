using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class C06CheckBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GetCheckBoxValue();
            GetCheckBoxListVal();
        }

        protected void GetCheckBoxListVal()
        {
            

            foreach(ListItem li in this.CheckBoxList1.Items)
            {
                Response.Write($"<br>Text = {li.Text}, Value = {li.Value}, Checked = {li.Selected}");
            }
        }

        protected void GetCheckBoxValue()
        {
            Response.Write($"Checkbox01 = {CheckBox1.Checked}<br>");
            Response.Write($"Checkbox02 = {CheckBox2.Checked}<br>");
            Response.Write($"Checkbox03 = {CheckBox3.Checked}<br>");
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            GetCheckBoxValue();
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            GetCheckBoxValue();
        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            GetCheckBoxValue();
        }
    }
}