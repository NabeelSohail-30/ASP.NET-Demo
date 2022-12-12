using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class C13ButtonsCmdEvent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Click Event Fired");
        }

        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            Response.Write("Command Event Fired");
        }

        protected void CheckButtons(object sender, CommandEventArgs e)
        {
            //Response.Write(e.CommandName);

            //if (e.CommandName == "Add")
            //{
            //    Response.Write("Add Button code");
            //}

            switch (e.CommandName)
            {
                case "Add":
                    {
                        Response.Write("Add Button code");
                        break;
                    }

                case "Edit":
                    {
                        if (e.CommandArgument.ToString() == "CmdEdit")
                        {
                            Response.Write("Edit Button code");
                        }
                        else if(e.CommandArgument.ToString() == "CmdPrint")
                        {
                            Response.Write("Print Button code");
                        }
                        break;
                    }

                case "View":
                    {
                        Response.Write("View Button code");
                        break;
                    }

                case "Delete":
                    {
                        Response.Write("Delete Button code");
                        break;
                    }
            }
        }
    }
}