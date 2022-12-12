using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo.DataGrid
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            ObjectDataSource1.InsertParameters["AuthorName"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("txtAuthor")).Text;
            ObjectDataSource1.InsertParameters["Gender"].DefaultValue = ((DropDownList)GridView1.FooterRow.FindControl("ddGender")).SelectedValue;
            ObjectDataSource1.InsertParameters["Active"].DefaultValue = ((CheckBox)GridView1.FooterRow.FindControl("checkActive")).Checked.ToString();

            ObjectDataSource1.Insert();
        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {

        }
    }
}