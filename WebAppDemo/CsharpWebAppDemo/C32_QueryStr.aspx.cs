using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class C32_QueryStr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //If data has no & sign value
            //string url = $"C32_QueryStr2.aspx?qsName={txtName.Text}&qsEmail={txtEmail.Text}";

            //If QS value has & sign in it's value
            //string url = $"C32_QueryStr2.aspx?qsName={Server.UrlEncode(txtName.Text)}&qsEmail={Server.UrlEncode(txtEmail.Text)}";

            //If QS value has & sign in it's value - manually replace char
            //string url = $"C32_QueryStr2.aspx?qsName={txtName.Text.Replace("&","%26")}&qsEmail={txtEmail.Text.Replace("&","%26")}";

            //encrypt qs value

            string url = $"C32_QueryStr2.aspx?qsName={Encrypt(txtName.Text)}&qsEmail={Encrypt(txtEmail.Text)}";
            //byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes("ABCDEF");

            Response.Redirect(url);
        }

        public string Encrypt(string str)
        {
            //Using Base64 Encryption Algorithm

            //Convert String into Byte[]
            byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes(str);

            //Convert Byte[] into Encoded String
            return Convert.ToBase64String(b);
            
        }
    }
}