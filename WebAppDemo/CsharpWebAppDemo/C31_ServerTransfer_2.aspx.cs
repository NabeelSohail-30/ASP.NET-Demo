using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class C31_ServerTransfer_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //GetDetail();
            //GetDetail2();
            GetDetail3();
        }

        private void GetDetail3()
        {

            //using strongly typed ref.

            //Page prevPage = this.Page.PreviousPage;
            //Using Previous Web Form Typecasting
            //C31_ServerTransfer prevPage = (C31_ServerTransfer)Page.PreviousPage;

            //Method 2: without Typecast: Add PreviousPage Directive in the Destination Page

            C31_ServerTransfer prevPage = PreviousPage;

            if (prevPage != null)
            {
                lblemail.Text = prevPage.Email;
                lblname.Text = prevPage.Name;
            }
        }

        private void GetDetail2()
        {

            //Method 02 - to retrieve submitted form values using previous page property - Page.PreviousPage.

            //Page prevPage = this.Page.PreviousPage;
            Page prevPage = Page.PreviousPage;

            //prevPage.IsCrossPagePostBack
            if (prevPage != null)
            {
                if (prevPage.IsCrossPagePostBack)
                {
                    TextBox prevPageEmail = (TextBox)prevPage.FindControl("txtEmails"); //Not a strongly Type.
                    TextBox prevPageName = (TextBox)prevPage.FindControl("txtName");

                    lblemail.Text = prevPageEmail.Text;
                    lblname.Text = prevPageName.Text + (prevPage.IsCrossPagePostBack);
                }
                else
                {

                    lblname.Text = "Page Accessed without using cross-page-post";
                }
            }
        }

        private void GetDetail()
        {
            //Method 01 - to retrive submitted form values using nameValueCollection.
            //Get the form values from the previous page
            //.net uses class System.Collections.Specialized.NameValueCollection to store previous form values

            System.Collections.Specialized.NameValueCollection prevFormVal = Request.Form;

            if (prevFormVal["txtEmail"] != null)
            {
                lblemail.Text = prevFormVal["txtEmail"].ToString();
            }

            if (prevFormVal["txtName"] != null)
            {
                lblname.Text = prevFormVal["txtName"].ToString();
            }

            //lblemail.Text = prevFormVal["txtEmail"].ToString();
            //lblname.Text = prevFormVal["txtName"].ToString();
        }
    }
}