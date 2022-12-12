using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class C10_CalanderControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                Calendar1.Visible = false;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar1.Visible)
                Calendar1.Visible = false;
            else
                Calendar1.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
           //ToShortDateString(), ToLongDateString, ToLongTimeString, ToShortTimeString()
            TxtDate.Text = Calendar1.SelectedDate.ToString();
            TxtShortDate.Text = Calendar1.SelectedDate.ToShortDateString();
            TxtLongDate.Text = Calendar1.SelectedDate.ToLongDateString();
            TxtShortTime.Text = Calendar1.SelectedDate.ToShortTimeString();
            TxtLongTime.Text = Calendar1.SelectedDate.ToLongTimeString();
            TxtCustom.Text = Calendar1.SelectedDate.ToString("yyyy-MM-dd");
            //Calendar1.Visible = false;

            //SelectionMode = DayWeek or DayWeekMonth
            foreach(DateTime myselecteddate in Calendar1.SelectedDates)
            {
                Response.Write(myselecteddate.ToShortDateString() + "<br>");
            }
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            /*
            //Disable Weekend and OtherMonth Date Selection
            if(e.Day.IsWeekend || e.Day.IsOtherMonth)
            {
                e.Day.IsSelectable = false;
                e.Cell.BackColor = System.Drawing.Color.LightGray;
            }
            */

            //Response.Write(e.Day.Date.ToShortDateString() + "<br>");

           
            DateTime dt = DateTime.Now;
            //Response.Write("Now = " + dt.ToShortDateString());

            if(dt.ToShortDateString() == e.Day.Date.ToShortDateString())
            {
                e.Cell.Text = "x";
                e.Cell.Font.Bold = true;
                e.Cell.ForeColor = System.Drawing.Color.White;
                e.Cell.ToolTip = "Booked";
            }
            else
            {
                e.Cell.ToolTip = "Available";
            }
        }

        protected void Calendar1_VisibleMonthChanged(object sender, MonthChangedEventArgs e)
        {
            Response.Write("Month Changed from " + GetMonthName(e.PreviousDate.Month) + " to " + GetMonthName(e.NewDate.Month));
        }

        private string GetMonthName(int month)
        {
            switch(month)
            {
                case 1:
                    return "Jan";
                case 2:
                    return "Feb";
                case 3:
                    return "March";
                case 4:
                    return "April";
                default:
                    return "Invalid";
            }
        }
    }
}