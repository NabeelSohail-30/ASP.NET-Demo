using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo.DataGrid
{
    public partial class WebForm25 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindDropDown();
        }

        private void BindDropDown()
        {
            foreach(int chartType in Enum.GetValues(typeof(SeriesChartType)))
            {
                ListItem li = new ListItem(Enum.GetName(typeof(SeriesChartType), chartType), chartType.ToString());
                DropDownList1.Items.Add(li);
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Chart1.Series["Series1"].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), DropDownList1.SelectedValue);
        }
    }
}