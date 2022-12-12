using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo.ServerMap.MapPath
{
    public partial class ServerMapPath : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<br><br>");
            Response.Write(". (Current Folder) returns = " + Server.MapPath("."));

            Response.Write("<br><br>");
            Response.Write(".. (Parent Folder) returns = " + Server.MapPath(".."));

            Response.Write("<br><br>");
            Response.Write("../.. (Parent of Parent Folder) returns = " + Server.MapPath("../.."));


            Response.Write("<br><br>");
            Response.Write("~ (Root Path) returns = " + Server.MapPath("~"));
        }
    }
}