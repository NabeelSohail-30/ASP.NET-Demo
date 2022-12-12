using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class C22_WizardControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page Load Event Fired<br>");

            if(!IsPostBack)
                Wizard1.ActiveStepIndex = 0;

            

        }

        protected void Wizard1_NextButtonClick(object sender, WizardNavigationEventArgs e)
        {
            Response.Write("Next Button Event Fired<br>");
            //Response.Write("Current:" + e.CurrentStepIndex + " - Next:" + e.NextStepIndex);

            

            if (e.NextStepIndex == 3)
            {
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
        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            Response.Redirect("https://www.google.com");
        }

        protected void Wizard1_PreRender(object sender, EventArgs e)
        {
            Response.Write("Pre Render Event Fired<br>");

            //switch (Wizard1.ActiveStepIndex)
            //{
            //    case 0:
            //        Wizard1.HeaderText = "Student";
            //        break;
            //    case 1:
            //        Wizard1.HeaderText = "Father";
            //        break;
            //    case 2:
            //        Wizard1.HeaderText = "Mother";
            //        break;
            //    case 3:
            //        Wizard1.HeaderText = "View";
            //        break;
            //}
        }

        protected void Wizard1_ActiveStepChanged(object sender, EventArgs e)
        {
            Response.Write("Active Step Event Fired<br>");
            switch (Wizard1.ActiveStepIndex)
            {
                case 0:
                    Wizard1.HeaderText = "Student";
                    break;
                case 1:
                    Wizard1.HeaderText = "Father";
                    break;
                case 2:
                    Wizard1.HeaderText = "Mother";
                    break;
                case 3:
                    Wizard1.HeaderText = "View";
                    break;
            }
        }

        protected void Wizard1_SideBarButtonClick(object sender, WizardNavigationEventArgs e)
        {
            Response.Write("Side Bar Btn Event Fired<br>");
        }

        //protected void Wizard1_CancelButtonClick(object sender, EventArgs e)
        //{
        //    Wizard1.ActiveStepIndex = 0;
        //}
    }
}