using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LMS;

namespace LMSWebApp
{
    public partial class BooksDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sLoginId"] == null)
            {
                Response.Redirect("LoginForm.aspx?LoginError=Your Session has been expired. Please login again to continue");
            }

            if (!IsPostBack)
            {
                BindComboAuthor();
                BindComboCategory();
                BindComboLanguage();
                BindComboPublisher();
                BindBooksGrid();
            }
            
        }

        private void BindBooksGrid()
        {
            Books book = new Books();
            this.GridBooks.DataSource = book.BooksAll();
            this.GridBooks.DataBind();
        }

        private void BindComboCategory()
        {
            Category category = new Category();
            this.ListCategory.DataSource = category.Categories();
            this.ListCategory.DataTextField = "Category";
            this.ListCategory.DataValueField = "CategoryId";
            this.ListCategory.DataBind();
        }

        private void BindComboAuthor()
        {
            Author author = new Author();
            this.ListAuthor.DataSource = author.Authors();
            this.ListAuthor.DataTextField = "AuthorName";
            this.ListAuthor.DataValueField = "AuthorId";
            this.ListAuthor.DataBind();
        }

        private void BindComboLanguage()
        {
            Language language = new Language();
            this.ListLanguage.DataSource = language.Languages();
            this.ListLanguage.DataTextField = "Language";
            this.ListLanguage.DataValueField = "LanguageId";
            this.ListLanguage.DataBind();
        }

        private void BindComboPublisher()
        {
            Publisher publisher = new Publisher();
            this.ListPublisher.DataSource = publisher.Publishers();
            this.ListPublisher.DataTextField = "Publisher";
            this.ListPublisher.DataValueField = "PublisherId";
            this.ListPublisher.DataBind();
        }

        protected void BtnAddNewBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("BooksDetailAdd.aspx");
        }

        protected void Btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("BooksDetailView.aspx");
        }
    }
}