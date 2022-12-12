using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CsharpWebAppDemo.Database.Models;

namespace CsharpWebAppDemo.DataGrid
{
    public partial class WebForm23 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                BindContinent();
        }

        private void BindContinent()
        {
            ListContinentRepo continent = new ListContinentRepo();
            GridView1.DataSource = continent.Find();
            GridView1.DataBind();
        }
    }
}