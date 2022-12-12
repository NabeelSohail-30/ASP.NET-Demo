using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class C21_MultiView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                MultiView1.ActiveViewIndex = 0;
        }

        protected void BtnNextFD_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void BtnPrevSD_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void BtnNextMD_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
        }

        protected void BtnPrevFD_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void BtnNextVD_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 3;
            Label10.Text = TxtStdName.Text;
            Label11.Text = TxtStdAge.Text;
            Label12.Text = TxtStdNationality.Text;
            Label13.Text = TxtFname.Text;
            Label14.Text = TxtFage.Text;
            Label15.Text = TxtFnationality.Text;
            Label16.Text = TxtMname.Text;
            Label17.Text = TxtMage.Text;
            Label18.Text = TxtMnationality.Text;
        }

        protected void BtnPrevMD_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            Response.Write("saved");
        }
    }
}