using CsharpWebAppDemo.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo.DataGrid
{
    public partial class WebForm21 : System.Web.UI.Page
    {
        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (GridView1.SelectedRow == null)
            {
                DetailsView1.Visible = false;
            }
            else
            {
                DetailsView1.Visible = true;
            }

            if (GridView2.SelectedRow == null)
            {
                DetailsView2.Visible = false;
            }
            else
            {
                DetailsView2.Visible = true;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindGrid();
        }

        private void BindGrid()
        {
            Author author = new Author();
            GridView3.DataSource = author.GetAllAuthors();
            GridView3.DataBind();
        }

        protected void GridView3_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "SelectRow")
            {
                Author author = new Author();
                int rowIndex = ((GridViewRow)((LinkButton)e.CommandSource).NamingContainer).RowIndex;

                GridView3.SelectRow(rowIndex);
                List<AuthorModel> listAuthor = new List<AuthorModel> { author.FindById(Convert.ToInt32(((GridView)sender).SelectedValue)) };
                DetailsView3.DataSource = listAuthor;
                DetailsView3.DataBind();
                GridView3.SelectedRowStyle.BackColor = System.Drawing.Color.Aqua;
            }
        }

        public void BindDetail3()
        {
            if (GridView3.SelectedDataKey != null)
            {
                DetailsView3.Visible = true;
                Author author = new Author();
                //int rowIndex = ((GridViewRow)((LinkButton)e.CommandSource).NamingContainer).RowIndex;

                //GridView3.SelectRow(rowIndex);
                List<AuthorModel> listAuthor = new List<AuthorModel> { author.FindById(Convert.ToInt32(((GridView)GridView3).SelectedDataKey.Value)) };
                DetailsView3.DataSource = listAuthor;
                DetailsView3.DataBind();
            }
        }

        protected void DetailsView1_ItemDeleted(object sender, DetailsViewDeletedEventArgs e)
        {
            GridView1.DataBind();
            GridView1.SelectRow(-1);
        }

        protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
        {
            GridView1.DataBind();
            GridView1.SelectRow(-1);

        }

        protected void DetailsView1_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
        {
            GridView1.DataBind();
            GridView1.SelectRow(-1);
        }

        protected void DetailsView2_ItemDeleted(object sender, DetailsViewDeletedEventArgs e)
        {
            GridView2.DataBind();
            GridView2.SelectRow(-1);
        }

        protected void DetailsView2_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
        {
            GridView2.DataBind();
            GridView2.SelectRow(-1);
        }

        protected void DetailsView2_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
        {
            GridView2.DataBind();
            GridView2.SelectRow(-1);
        }

        protected void DetailsView3_ModeChanging(object sender, DetailsViewModeEventArgs e)
        {
            DetailsView3.ChangeMode(e.NewMode);
            BindDetail3();
        }

        protected void DetailsView3_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
        {
            //e.NewValues[]
        }

        protected void DetailsView3_ItemInserting(object sender, DetailsViewInsertEventArgs e)
        {
            //e.Values[]
        }
    }


}