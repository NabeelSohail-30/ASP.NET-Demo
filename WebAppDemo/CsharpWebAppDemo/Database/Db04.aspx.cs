using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CsharpWebAppDemo.Database.Models;
using System.Configuration;

namespace CsharpWebAppDemo.Database
{
    public partial class Db04 : System.Web.UI.Page
    {
        string HostUrl = ConfigurationManager.AppSettings["HostURL"];
        bool IsSiteUp = bool.Parse(ConfigurationManager.AppSettings["IsSiteUp"]);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsSiteUp)
            {
                if (!IsPostBack)
                {
                    FillDropDownAuthor();
                    FillDropDownCategory();
                }
            }
            else
            {
                Response.Write("<h1>Site is under maintainance.</h1>");
                Response.End();
            }
        }

        private void FillDropDownAuthor()
        {
            Author ListAuthor = new Author();

            this.ListAuthor.Items.Add(new ListItem("Select Author", "-1"));
            foreach(AuthorModel AuthorDetail in ListAuthor.GetAllAuthors())
            {
                //Response.Write($"<br> {AuthorDetail.AuthorId}, {AuthorDetail.AuthorName}");
                this.ListAuthor.Items.Add(new ListItem(AuthorDetail.AuthorName, AuthorDetail.AuthorId.ToString()));
            }
        }

        private void FillDropDownCategory()
        {
            Category ListCategory = new Category();
            this.ListCategory.Items.Add(new ListItem("Select Category", "-1"));

            foreach(CategoryModel Category in ListCategory.GetAllCategories())
            {
                this.ListCategory.Items.Add(new ListItem(Category.Category, Category.CategoryId.ToString()));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect(HostUrl + "SimpleCounter.aspx");
        }
    }
}