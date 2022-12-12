using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class C09DropDownRunTimeVal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                FillDropDown();
                FillEducation();
                FillGender();
            }
        }
        private void FillGender()
        {
            //DropDownList3.Items.Clear();
            ListItem[] ListGender = new ListItem[3];
        
            for(int a=0;a<ListGender.Length;a++)
            {
                ListGender[a] = new ListItem();
            }

            ListGender[0].Text = "Select Gender";
            ListGender[0].Value = "-1";
            ListGender[0].Selected = true;


            ListGender[1].Text = "Male";
            ListGender[1].Value = "1";


            ListGender[2].Text = "Female";
            ListGender[2].Value = "2";

            this.DropDownList3.Items.AddRange(ListGender);
        }

        private void FillEducation()
        {
            //DropDownList2.Items.Clear();
            this.DropDownList2.Items.Add(new ListItem("Select Education", "-1", true));
            this.DropDownList2.Items.Add(new ListItem("Matriculation", "1"));
            this.DropDownList2.Items.Add(new ListItem("Intermediate", "2"));
            this.DropDownList2.Items.Add(new ListItem("Graduation", "3"));
        }

        protected void FillDropDown()
        {
            //Add items into Drop Down

            //DropDownList1.Items.Clear();
            //Create 1st Item
            ListItem item1 = new ListItem();
            item1.Value = "-1";
            item1.Text = "Select Country";
            item1.Selected = true;

            ListItem item2 = new ListItem("Pakistan", "101");
            ListItem item3 = new ListItem("Kuwait", "102");
            ListItem item4 = new ListItem("London", "103");

            this.DropDownList1.Items.Add(item1);
            this.DropDownList1.Items.Add(item2);
            this.DropDownList1.Items.Add(item3);
            this.DropDownList1.Items.Add(item4);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write($"Country = {DropDownList1.SelectedItem}");
            Response.Write($"<br>Count = {DropDownList1.Items.Count}");
        }
    }
}