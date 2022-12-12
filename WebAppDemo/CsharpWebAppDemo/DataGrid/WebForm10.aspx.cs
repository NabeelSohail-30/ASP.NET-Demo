using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CsharpWebAppDemo.Database.Models;

namespace CsharpWebAppDemo.DataGrid
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //LoginUsers login = new LoginUsers();
            //GridView1.DataSource = login.GetAllUsers();
            //GridView1.DataBind();

        }

        protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
           if(e.AffectedRows <0)
            {
                e.KeepInEditMode = true;
                Response.Write($"Row with AuthorID {e.Keys[0].ToString()} is not updated due to conflcit");
            }
        }

        protected void ObjectDataSource1_Updated(object sender, ObjectDataSourceStatusEventArgs e)
        {
            if((int)e.ReturnValue > 0)
            {
                e.AffectedRows = (int)e.ReturnValue;
            }
        }
    }
}