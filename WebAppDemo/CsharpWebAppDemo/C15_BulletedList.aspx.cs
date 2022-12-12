using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class C15_BulletedList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
        {

            //e.index will return the clicked item index position
            ListItem li = this.BulletedList1.Items[e.Index];

            Response.Write(e.Index);
            Response.Write("<br>");
            Response.Write(li.Text);
            Response.Write("<br>");
            Response.Write(li.Value);

        }
    }
}