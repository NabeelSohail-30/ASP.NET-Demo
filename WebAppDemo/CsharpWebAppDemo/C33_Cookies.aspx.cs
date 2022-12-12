using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class C33_Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckBrowserSupportCookie();
            if(!IsPostBack)
                IsCookieEnable();
        }

        private void IsCookieEnable()
        {
            if (Request.Browser.Cookies)
            {
                if(Request.QueryString["CheckCookie"]==null)
                {
                    HttpCookie temp = new HttpCookie("temp","1");
                    Response.Cookies.Add(temp);
                    Response.Redirect("C33_Cookies.aspx?CheckCookie=1");
                }
                else
                {
                    if(Request.Cookies["temp"] == null)
                    {
                        Response.Write("Cookies disabled");
                    }
                }
            }
            else
            {
                Response.Write("Your browser does not support cookie");
            }
        }

        private void CheckBrowserSupportCookie()
        {
            Response.Write($"Browser Supports Cookie: {Request.Browser.Cookies}");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Code .....

            //Create Cookie on client device
            HttpCookie cookie = new HttpCookie("UserDetails");
            cookie["cEmail"] = this.txtEmail.Text;
            cookie["cName"] = this.txtName.Text;

            //Set Expiry so cookie can be Persistent.
            //DateTime expirydate = new DateTime();

            cookie.Expires = DateTime.Now.AddDays(10);

            Response.Cookies.Add(cookie);

            Response.Redirect("C33_CookieRead.aspx");
            

            //code here .... 

        }
    }
}