using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo.DataGrid
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        int datfound = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
            datfound = 0;
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            Response.Write("row data fired");

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                datfound++;
            }


            //if(e.Row.RowType==DataControlRowType.Footer)
            //{
                
            //}
        }

        protected void GridView1_PreRender(object sender, EventArgs e)
        {
            Response.Write("Pre Render fired");
            if (datfound == 0)
            {
                Label1.Visible = true;
                Label1.Text = "There is no data filtered.";
            }
            else
            {
                Label1.Visible = false;
            }
        }
    }
}