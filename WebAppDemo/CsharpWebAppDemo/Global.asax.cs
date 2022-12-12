using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace CsharpWebAppDemo
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //first user browse
            Application["UsersOnline"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            //for every user

            Application.Lock();
            Application["UsersOnline"] = (int)Application["UsersOnline"] + 1;
            Application.UnLock();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            //on error
        }

        protected void Session_End(object sender, EventArgs e)
        {
            //on user close app/browser
            Application.Lock();
            Application["UsersOnline"] = (int)Application["UsersOnline"] - 1;
            Application.UnLock();
        }

        protected void Application_End(object sender, EventArgs e)
        {
            //on stop app
        }
    }
}