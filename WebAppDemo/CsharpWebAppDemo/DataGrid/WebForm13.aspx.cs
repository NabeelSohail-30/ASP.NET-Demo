using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CsharpWebAppDemo.Database.Models;

namespace CsharpWebAppDemo.DataGrid
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                BindGrid();
        }

        private void BindGrid()
        {
            Author author = new Author();
            GridView1.DataSource = author.GetAllAuthors();
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "InsertRow":
                    {
                        //Control ctrlAuthor = GridView1.FooterRow.FindControl("txtAuthor");
                        //TextBox txtAuthor = (TextBox)ctrlAuthor;

                        string AuthorName = ((TextBox)GridView1.FooterRow.FindControl("txtAuthor")).Text;
                        string Gender = ((DropDownList)GridView1.FooterRow.FindControl("ddGender")).SelectedValue;
                        bool Active = ((CheckBox)GridView1.FooterRow.FindControl("ckActive")).Checked;

                        Author author = new Author();
                        author.AddAuthor(AuthorName, Gender, Active);

                        BindGrid();

                        break;
                    }

                case "EditRow":
                    {
                        int rowIndex = ((GridViewRow)((LinkButton)e.CommandSource).NamingContainer).RowIndex;
                        GridView1.EditIndex = rowIndex;
                        BindGrid();

                        //int id = Convert.ToInt32(e.CommandArgument);
                        //Response.Redirect($"Sample.aspx?id={id}");

                        break;
                    }

                case "UpdateRow":
                    {
                        int rowIndex = ((GridViewRow)((LinkButton)e.CommandSource).NamingContainer).RowIndex;

                        string AuthorName = ((TextBox)GridView1.Rows[rowIndex].FindControl("txtUpdateAuthor")).Text;
                        string Gender = ((DropDownList)GridView1.Rows[rowIndex].FindControl("ddUpdateGender")).SelectedValue;
                        bool Active = ((CheckBox)GridView1.Rows[rowIndex].FindControl("ckUpdateActive")).Checked;
                        //when authorid(pk) is displayed in the grid
                        //int AuthorId = int.Parse(((Label)GridView1.Rows[rowIndex].FindControl("lblAuthorId")).Text);

                        //when pk is not displayed in the grid
                        int AuthorId = Convert.ToInt32(e.CommandArgument);


                        Author author = new Author();
                        author.UpdateAuthor(AuthorId, AuthorName, Gender, Active);

                        BindGrid();

                        break;
                    }

                case "CancelUpdate":
                    {
                        GridView1.EditIndex = -1;
                        BindGrid();
                        break;
                    }

                case "DeleteRow":
                    {
                        int AuthorId = Convert.ToInt32(e.CommandArgument);

                        Author author = new Author();
                        author.DeleteById(AuthorId);

                        BindGrid();

                        break;
                    }

                case "ViewRecord":
                    {
                        int AuthorId = Convert.ToInt32(e.CommandArgument);

                        Response.Redirect($"Sample.aspx?id={AuthorId}");

                        break;
                    }
            }
        }
    }
}