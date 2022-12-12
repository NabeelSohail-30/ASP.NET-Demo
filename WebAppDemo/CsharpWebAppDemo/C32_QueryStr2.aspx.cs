using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class C32_QueryStr2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetQsData();
        }

        private void GetQsData()
        {
            lblemail.Text = Decrypt(Request.QueryString["qsEmail"]);
            lblname.Text = Decrypt(Request.QueryString["qsName"]);
        }

        public string Decrypt(string str)
        {
            //Using Base64 dEcryption Algorithm

            //Convert Encrypted String into Byte[]
            byte[] b = Convert.FromBase64String(str);

            //Convert Byte[] into String
            return System.Text.ASCIIEncoding.ASCII.GetString(b);

        }
    }
}