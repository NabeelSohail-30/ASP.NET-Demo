using CsharpWebAppDemo.Database.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo.DataGrid
{
    public partial class WebForm27 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindChartDv();

        }

        private void BindChartProgramitaclly()
        {
            List<AuthorModel> list = new List<AuthorModel>();
            Author author = new Author();

            list = author.GetAllAuthors();

            Series series = Chart1.Series["Series1"];

            foreach (AuthorModel model in list)
            {
                series.Points.AddXY(model.AuthorName, model.Qty);
            }
        }

        private void BindChart()
        {
            List<AuthorModel> list = new List<AuthorModel>();
            Author author = new Author();

            list = author.GetAllAuthors();

            Chart1.Series["Series1"].XValueMember = "AuthorName";
            Chart1.Series["Series1"].YValueMembers = "Qty";
            Chart1.DataSource = list;
            Chart1.DataBind();
        }

        private void BindChartDv()
        {
            Author author = new Author();
            DataView dv = author.GetAllAuthors3();
            Chart1.Series["Series1"].XValueMember = "AuthorName";
            Chart1.Series["Series1"].YValueMembers = "Qty";
            dv.Sort = "Qty DESC";
            dv.RowFilter = "Qty > 5";
            Chart1.DataSource = dv;
            Chart1.DataBind();
        }
    }
}