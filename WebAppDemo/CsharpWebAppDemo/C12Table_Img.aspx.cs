using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class C12Table_Img : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                TableGenerate();
                HTMLTableGenerator();
            }
        }

        private void TableGenerate()
        {
            int Rows = 5;
            int Cols = 6;

            TableRow tr;
            TableCell tc;
            Table2.BorderStyle = BorderStyle.Dotted;

            for(int i =1;i<=Rows;i++)
            {
                tr = new TableRow();
                for(int c =1;c<=Cols;c++)
                {
                    tc = new TableCell();
                    tc.Text = $"Row {i} Col {c}";
                    tr.Cells.Add(tc);
                }
                this.Table2.Rows.Add(tr);
            }

        }

        private void HTMLTableGenerator()
        {
            int Rows = 5;
            int Cols = 6;

            Response.Write("<Table style='border:2px solid black;'>");

            for (int i = 1; i <= Rows; i++)
            {
                Response.Write("<tr>");
                for (int c = 1; c <= Cols; c++)
                {
                    Response.Write("<td>");
                    Response.Write($"Row {i} Col {c}");
                    Response.Write("</tr>");
                }
                Response.Write("</tr>");
            }

            Response.Write("</table>");
        }
    }
}