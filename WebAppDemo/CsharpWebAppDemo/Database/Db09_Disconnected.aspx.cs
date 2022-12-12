using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CsharpWebAppDemo.Database.Models;

namespace CsharpWebAppDemo.Database
{
    public partial class Db09_Disconnected : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            Author author = new Author();

            //GridView1.DataSource = author.AuthorsDisconnected();
            GridView1.DataSource = author.AuthorsDisconnectedDS();
            GridView1.DataBind();
        }
    }
}