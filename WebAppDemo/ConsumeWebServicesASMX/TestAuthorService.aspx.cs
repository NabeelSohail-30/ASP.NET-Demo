using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumeWebServicesASMX
{
    public partial class TestAuthorService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             
            BindGrid();
        }

        private void BindGrid()
        {
            AuthorServiceReference.AuthorSoapClient authorClient = new AuthorServiceReference.AuthorSoapClient();
            GridView1.DataSource = authorClient.GetAuthors();
            GridView1.DataBind();
            Response.Write(authorClient.Update());
            Label1.Text = authorClient.SessionValue().ToString();
            
        }
    }
}