using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo.DataGrid
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SqlDataSource1.InsertParameters["LoginEmail"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("txtEmail")).Text;
            SqlDataSource1.InsertParameters["UserFullName"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("txtName")).Text ;
            SqlDataSource1.InsertParameters["LoginPassword"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("txtPass")).Text;
            SqlDataSource1.InsertParameters["UserRoleId"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("txtRoleId")).Text;
            SqlDataSource1.InsertParameters["IsActive"].DefaultValue = ((CheckBox)GridView1.FooterRow.FindControl("ckActive")).Checked.ToString();

            SqlDataSource1.Insert();
        }
    }
}