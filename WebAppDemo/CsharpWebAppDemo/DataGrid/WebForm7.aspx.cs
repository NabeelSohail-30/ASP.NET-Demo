using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo.DataGrid
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Control ctl = e.Row.Cells[0].Controls[0];
                if (ctl is LinkButton)
                {
                    ((LinkButton)ctl).OnClientClick = "return confirm('Are you sure to delete?');";
                }

            }

        }

        protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
            Response.Write(e.AffectedRows);

            if (e.AffectedRows > 0)
            {
                Label1.Text = $"Author row with Author ID {e.Keys[0].ToString()} is successfully deleted.";
                Label1.ForeColor = System.Drawing.Color.ForestGreen;
            }
            else
            {
                Label1.Text = $"Author row with Author ID {e.Keys[0].ToString()} is not deleted due to data conflict";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}