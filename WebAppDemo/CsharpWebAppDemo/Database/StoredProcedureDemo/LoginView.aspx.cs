using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CsharpWebAppDemo.Database.Models;

namespace CsharpWebAppDemo.Database.StoredProcedureDemo
{
    public partial class LoginView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                BindGrid();

        }

        private void BindGrid()
        {
            LoginUsers login = new LoginUsers();
            //GridView1.DataSource = login.GetAllUsers();
            //GridView1.DataBind();
            Response.Write(login.GetAllUsers().Count);
        }
    }
}