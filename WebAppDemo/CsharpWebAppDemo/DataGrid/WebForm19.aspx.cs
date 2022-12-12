using CsharpWebAppDemo.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo.DataGrid
{
    public partial class WebForm19 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
                BindGrid5(0,GridView5.PageSize);
            }
        }

        protected void GridView2_PreRender(object sender, EventArgs e)
        {
            Label1.Text = $"{GridView2.PageIndex + 1} / {GridView2.PageCount}";

        }

        private void BindGrid()
        {
            Author author = new Author();
            GridView3.DataSource = author.GetAllAuthors();
            GridView3.DataBind();
        }

        private void BindGrid5(int PageIndex, int PageSize)
        {
            Author author = new Author();
            GridView5.DataSource = author.GetAllAuthorsPageWise2(PageIndex,PageSize);
            GridView5.DataBind();

            int TotalRows = author.Count();

            int totalPages = TotalRows / PageSize;

            if ((TotalRows % PageSize) != 0)
            {
                totalPages += 1;
            }

            List<ListItem> pages = new List<ListItem>();
            if(totalPages > 1)
            {
                for(int i=1;i<=totalPages;i++)
                {
                    pages.Add(new ListItem("Page " + i.ToString(), i.ToString(), i != (PageIndex + 1)));
                }
            }

            repeaterPaging.DataSource = pages;
            repeaterPaging.DataBind();

        }

        protected void GridView3_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            ((GridView)sender).PageIndex = e.NewPageIndex;
            BindGrid();
        }

        protected void pagingLinkButton_Click(object sender, EventArgs e)
        {
            int pageIndex = int.Parse((sender as LinkButton).CommandArgument);
            pageIndex -= 1;

            GridView5.PageIndex = pageIndex;
            BindGrid5(pageIndex, GridView5.PageSize);
        }
    }
}