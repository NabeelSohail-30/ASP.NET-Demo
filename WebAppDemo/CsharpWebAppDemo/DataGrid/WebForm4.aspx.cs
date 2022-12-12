using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo.DataGrid
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Thread.CurrentThread.CurrentCulture = new CultureInfo("en-PK");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                Response.Write(ci.Name + " __ " + ci.DisplayName + " __ " + ci.EnglishName + "<br>");
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //Response.Write(e.Row.Cells[2].Text);
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.Cells[4].Text == "1")
                {
                    e.Row.Cells[4].Text = "Male";
                }
                else
                {
                    e.Row.Cells[4].Text = "Female";
                }

                //if(e.Row.Cells[5].Text == "Pakistani")
                //{
                //    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-PK");
                //}
                //else if(e.Row.Cells[5].Text == "Canadian")
                //{
                //    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
                //}
                //else if (e.Row.Cells[5].Text == "American")
                //{
                //    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                //}
                //else if (e.Row.Cells[5].Text == "Turkish")
                //{
                //    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-TR");
                //}
                //else if (e.Row.Cells[5].Text == "Australian")
                //{
                //    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-AU");
                //}
                //else if (e.Row.Cells[5].Text == "British")
                //{
                //    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
                //}

                //using cell[index]
                //decimal salary = Convert.ToDecimal(e.Row.Cells[6].Text);

                decimal salary = Convert.ToDecimal(DataBinder.Eval(e.Row.DataItem,"AnnualPay"));
                
                //change row color if sal > 150,000

                if(salary >= 150000)
                {
                    e.Row.Cells[6].BackColor = System.Drawing.Color.Red;
                    e.Row.Cells[6].ForeColor = System.Drawing.Color.White;
                    
                }


                if (e.Row.Cells[5].Text == "Pakistani")
                {
                    string formattedString = string.Format(new CultureInfo("en-PK"), "{0:c}", salary);
                    e.Row.Cells[6].Text = formattedString;
                }
                else if (e.Row.Cells[5].Text == "Canadian")
                {
                    //decimal salary = Convert.ToDecimal(e.Row.Cells[6].Text);
                    string formattedString = string.Format(new CultureInfo("en-CA"), "{0:c}", salary);
                    e.Row.Cells[6].Text = formattedString;
                }
                else if (e.Row.Cells[5].Text == "American")
                {
                    //decimal salary = Convert.ToDecimal(e.Row.Cells[6].Text);
                    string formattedString = string.Format(new CultureInfo("en-US"), "{0:c}", salary);
                    e.Row.Cells[6].Text = formattedString;
                }
                else if (e.Row.Cells[5].Text == "Turkish")
                {
                    //decimal salary = Convert.ToDecimal(e.Row.Cells[6].Text);
                    string formattedString = string.Format(new CultureInfo("en-TR"), "{0:c}", salary);
                    e.Row.Cells[6].Text = formattedString;
                }
                else if (e.Row.Cells[5].Text == "Australian")
                {
                    //decimal salary = Convert.ToDecimal(e.Row.Cells[6].Text);
                    string formattedString = string.Format(new CultureInfo("en-AU"), "{0:c}", salary);
                    e.Row.Cells[6].Text = formattedString;
                }
                else if (e.Row.Cells[5].Text == "British")
                {
                    //decimal salary = Convert.ToDecimal(e.Row.Cells[6].Text);
                    string formattedString = string.Format(new CultureInfo("en-GB"), "{0:c}", salary);
                    e.Row.Cells[6].Text = formattedString;
                }
            }

            //e.Row.Cells[2].Visible = false;
        }
    }
}