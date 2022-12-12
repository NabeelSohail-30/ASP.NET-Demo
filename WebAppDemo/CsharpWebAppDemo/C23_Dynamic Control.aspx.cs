using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class C23_Dynamic_Control : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                CreateControls();

        }

        private void CreateControls()
        {
            //Create Label Control
            //Label lbl = new Label();
            //lbl.Text = "Enter Name: ";

            ////Create Text Box
            //TextBox txtbox = new TextBox();

            ////Create Button
            //Button btn = new Button();
            //btn.Text = "Save";

            //Add to Panel
            //Panel1.Controls.Add(lbl);
            //Panel1.Controls.Add(txtbox);
            //Panel1.Controls.Add(btn);

            //Add to Page
            //this.Controls.Add(lbl);
            //this.Controls.Add(txtbox);
            //this.Controls.Add(btn);

            //Add to form
            //form1.Controls.Add(lbl);
            //form1.Controls.Add(txtbox);
            //form1.Controls.Add(btn);

            //td1.Controls.Add(lbl);
            //td2.Controls.Add(txtbox);
            //td3.Controls.Add(btn);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int count = int.Parse(TextBox1.Text);
            string txtId = "TxtBox";
            
            for(int i = 0; i < count; i++)
            {
                TextBox txt = new TextBox();
                txt.ID = txtId + i;
                Panel1.Controls.Add(txt);
            }

            foreach (Control ctl in Panel1.Controls)
            {
                Response.Write(ctl);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Dynamic Controls cannot be access directly by using their Ids

            //Control ctl = Panel1.FindControl("TxtBox0");
            //Response.Write(((TextBox)ctl).Text);

            foreach(Control ctl in Panel1.Controls)
            {
                Response.Write(ctl);
            }
        }
    }
}