using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo.DataGrid
{
    public partial class WebForm26 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                getChartData();
        }

        private void getChartData()
        {
            Series series = Chart1.Series["Series1"];

            //Add X and Y values using AddXy() method
            series.Points.AddXY("Nabeel", 800);
            series.Points.AddXY("Ahmed", 700);
            series.Points.AddXY("Khizar", 500);
            series.Points.AddXY("Salik", 650);
            series.Points.AddXY("Daniyal", 320);
            
        }
    }
}