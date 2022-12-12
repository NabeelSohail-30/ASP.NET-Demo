using CsharpWebAppDemo.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo.DataGrid
{
    public partial class WebForm18 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindGrid("AuthorId");
        }

        private void BindGrid(string sortexpression)
        {
            Author author = new Author();
            GridView1.DataSource = author.GetAllAuthors(sortexpression);
            GridView1.DataBind();
        }

        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {
            //Response.Write($"{e.SortExpression} - {e.SortDirection}");

            SortDirection sortDirection = SortDirection.Ascending;
            string sortField = string.Empty;

            SortGridView((GridView)sender, e, out sortDirection, out sortField);
            string strSortDirection = sortDirection == SortDirection.Ascending ? "ASC" : "DESC";

            BindGrid(e.SortExpression + " " + strSortDirection);
        }

        public void SortGridView(GridView grid, GridViewSortEventArgs e, out SortDirection sortDirection, out string sortField)
        {
            sortField = e.SortExpression;
            sortDirection = e.SortDirection;

            if(grid.Attributes["CurrentSortField"]!=null && grid.Attributes["CurrentSortDirection"] != null)
            {
                if(sortField == grid.Attributes["CurrentSortField"])
                {
                    if(grid.Attributes["CurrentSortDirection"]=="ASC")
                    {
                        sortDirection = SortDirection.Descending;

                    }
                    else
                    {
                        sortDirection = SortDirection.Ascending;
                    }
                }
                grid.Attributes["CurrentSortField"] = sortField;
                grid.Attributes["CurrentSortDirection"] = (sortDirection == SortDirection.Ascending ? "ASC" : "DESC");
            }

        }

        protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (GridView1.Attributes["CurrentSortField"] != null && GridView1.Attributes["CurrentSortDirection"] != null)
            {
                if(e.Row.RowType==DataControlRowType.Header)
                {
                    foreach(TableCell  tableCell in e.Row.Cells)
                    {
                        if(tableCell.HasControls())
                        {
                            LinkButton sortLinkButton = null;
                            if(tableCell.Controls[0] is LinkButton)
                            {
                                sortLinkButton = (LinkButton)tableCell.Controls[0];

                            }
                            if(sortLinkButton !=null && GridView1.Attributes["CurrentSortField"]==sortLinkButton.CommandArgument)
                            {
                                Image image = new Image();

                                if(GridView1.Attributes["CurrentSortDirection"]=="ASC")
                                {
                                    image.ImageUrl = "~/Images/up.png";
                                }
                                else
                                {
                                    image.ImageUrl = "~/Images/down.png";
                                }
                                tableCell.Controls.Add(new LiteralControl("&nbsp;"));
                                tableCell.Controls.Add(image);
                            }
                        }
                    }
                }
            }
        }
    }
}