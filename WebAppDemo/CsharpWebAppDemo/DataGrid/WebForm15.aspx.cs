using CsharpWebAppDemo.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo.DataGrid
{
    public partial class WebForm15 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ckSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                //((CheckBox)row.FindControl("ckSelect")).Checked = ((CheckBox)GridView1.HeaderRow.FindControl("ckSelectAll")).Checked;
                ((CheckBox)row.FindControl("ckSelect")).Checked = ((CheckBox)sender).Checked;
            }
        }

        protected void ckSelect_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox SelectAll = ((CheckBox)GridView1.HeaderRow.FindControl("ckSelectAll"));

            if (SelectAll.Checked)
            {
                SelectAll.Checked = ((CheckBox)sender).Checked;
            }
            else
            {
                bool allCheckBoxesChecked = true;
                foreach (GridViewRow gridviewrow in GridView1.Rows)
                {
                    if (!((CheckBox)gridviewrow.FindControl("ckSelect")).Checked)
                    {
                        allCheckBoxesChecked = false;
                        break;
                    }
                }

                SelectAll.Checked = allCheckBoxesChecked;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<string> SelectedIds = new List<string>();

            foreach (GridViewRow row in GridView1.Rows)
            {
                if (((CheckBox)row.FindControl("ckSelect")).Checked)
                {
                    SelectedIds.Add(((Label)row.FindControl("Label1")).Text);
                }
            }

            if (SelectedIds.Count <= 0)
            {
                Response.Write("No rows selected for delte ");
            }
            else
            {
                //Delete one by one record using DeleteById(int id) method
                //foreach (String str in SelectedIds)
                //{
                //    //Response.Write(str + "<br>");

                //    // Call DeleteById(int Id) Method 


                //}

                //Method 2: Delete all at one shot using DeleteMulitpleIDs(List<string> Ids) method

                //DELETE FROM ListAuthor Where Id =1 or id=2
                //Delete from ListAuthor where Id In(1,2,3,5,7)
                //Ids contains list of Id
                //DELET FROM ListAuthor WHERE id IN( {BuildString})

                Author author = new Author();
                author.DeleteById(SelectedIds);

                Response.Redirect("WebForm15.aspx");
            }
        }
    }
}