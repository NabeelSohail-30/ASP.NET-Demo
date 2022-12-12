using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo.Database
{
    public partial class Db13_ReadFromXML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindGrid();
            BindDropDown();
        }

        private void BindDropDown()
        {
            string XMLFilePath = Server.MapPath("~/Data/Author.xml");

            DataSet DS = new DataSet();
            DS.ReadXml(XMLFilePath);

            DropDownList1.DataTextField = "author";
            DropDownList1.DataValueField = "id";
            DropDownList1.DataSource = DS;
            DropDownList1.DataBind();
            
        }

        private void BindGrid()
        {
            string XMLFilePath = Server.MapPath("~/Data/Catalog.xml");

            DataSet DS = new DataSet();
            DS.ReadXml(XMLFilePath);

            GridView1.DataSource = DS;
            GridView1.DataBind();
        }
    }
}