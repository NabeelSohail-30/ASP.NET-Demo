using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class C08ListBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int[] ListSelectedIndices = ListBox1.GetSelectedIndices();

            foreach (int i in ListSelectedIndices)
            {
                Response.Write($"<br>Index = {i}");
                Response.Write($" - Text = {ListBox1.Items[i].Text}");
                Response.Write($" - Val = {ListBox1.Items[i].Value}");
            }

        }
    }
}