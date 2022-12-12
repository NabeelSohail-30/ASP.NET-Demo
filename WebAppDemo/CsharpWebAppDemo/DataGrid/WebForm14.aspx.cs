using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo.DataGrid
{
    public partial class WebForm14 : System.Web.UI.Page
    {
        int GrandTotal = 0;
        double TotPrice = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //method 01 to retrieve cell value
                //GrandTotal += Convert.ToInt32(e.Row.Cells[5].Text);
                //TotPrice += Convert.ToDouble(e.Row.Cells[4].Text);

                //method 02 to retrieve cell value
                GrandTotal += (int)DataBinder.Eval(e.Row.DataItem, "Qty");
                TotPrice += Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "TotalPrice"));
            }
            else if (e.Row.RowType == DataControlRowType.Footer)
            {
                e.Row.Cells[5].Font.Bold = true;
                e.Row.Cells[4].Font.Bold = true;
                e.Row.Cells[1].Font.Bold = true;
                e.Row.Cells[5].Text = GrandTotal.ToString();
                e.Row.Cells[4].Text = TotPrice.ToString();
                e.Row.Cells[1].Text = "Grand Total";
            }
        }
    }
}