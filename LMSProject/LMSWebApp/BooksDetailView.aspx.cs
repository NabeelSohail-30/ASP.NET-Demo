using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LMS;

namespace LMSWebApp
{
    public partial class BooksDetailView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sLoginId"] == null)
            {
                Response.Redirect("LoginForm.aspx?LoginError=Your Session has been expired. Please login again to continue");
            }
        }

        protected void BtnFind_Click(object sender, EventArgs e)
        {
            int BookId = int.Parse(TxtId.Text);

            BooksModel bookmodel = new BooksModel();
            Books book = new Books();
            bookmodel = book.Find(BookId);

            TxtBookName.Text = bookmodel.BookName;
            TxtCategory.Text = bookmodel.Category.Category;
            TxtAuthor.Text = bookmodel.Author.AuthorName;
            TxtPublisher.Text = bookmodel.Publisher.Publisher;
            TxtBookPages.Text = bookmodel.BookPages.ToString();
            TxtQty.Text = bookmodel.Quantity.ToString();
            TxtLanguage.Text = bookmodel.Language.Language;
            TxtCabinet.Text = bookmodel.Cabinet.Cabinet.ToString();
            TxtShelve.Text = bookmodel.Shelve.Shelve.ToString();
        }
    }
}