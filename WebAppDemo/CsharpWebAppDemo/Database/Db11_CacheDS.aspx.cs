using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CsharpWebAppDemo.Database.Models;
using System.Data;

namespace CsharpWebAppDemo.Database
{
    public partial class Db11_CacheDS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                BindGrid();
        }

        private void BindGrid()
        {
            if (Cache["AuthorData"] == null)
            {
                //load data from SQL DB
                Author author = new Author();
                //DataSet ds = new DataSet();
                //ds = author.AuthorsDisconnectedDS2();
                //GridView1.DataSource = ds;
                GridView1.DataSource = author.AuthorsDisconnectedDS();
                //Cache DS
                //Cache["AuthorData"] = ds;
                Cache["AuthorData"] = author.AuthorsDisconnectedDS();
                LblMessage.Text = "Loaded From DB";
            }
            else
            {
                GridView1.DataSource = Cache["AuthorData"];
                LblMessage.Text = "Loaded from Cache";
            }
            
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            if(Cache["AuthorData"] != null)
                Cache.Remove("AuthorData");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            GridView1.DataSource = author.FindAll(TxtSearch.Text);
            GridView1.DataBind();
        }
    }
}