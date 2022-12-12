using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CsharpWebAppDemo.Database.Models;

namespace CsharpWebAppDemo.DataGrid
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            Books book = new Books();
            GridView1.DataSource = book.GetAllBooks();
            GridView1.DataBind();
        }
    }
}