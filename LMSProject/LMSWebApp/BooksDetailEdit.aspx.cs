using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using LMS;

namespace LMSWebApp
{
    public partial class BooksDetailEdit : System.Web.UI.Page
    {
        int BookId;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sLoginId"] == null)
            {
                Response.Redirect("LoginForm.aspx?LoginError=Your Session has been expired. Please login again to continue");
            }

            HideExceptionLabels();

            if (!IsPostBack)
            {
                BindComboAuthor();
                BindComboCategory();
                BindComboLanguage();
                BindComboPublisher();
                BindComboShelve();
                BindComboCabinet();
                ListCategory.Attributes.Add("onchange", "ValidateOtherOption(this, document.getElementById('TxtCategory'));");
                ListAuthor.Attributes.Add("onchange", "ValidateOtherOption(this, document.getElementById('TxtAuthor'));");
                ListPublisher.Attributes.Add("onchange", "ValidateOtherOption(this, document.getElementById('TxtPublisher'));");
            }
        }

        private void HideExceptionLabels()
        {
            LblExceptionId.Visible = false;
            LblExceptionBookName.Visible = false;
            LblExceptionAuthor.Visible = false;
            LblException.Visible = false;
            LblExceptionBookPages.Visible = false;
            LblExceptionCabinet.Visible = false;
            LblExceptionCategory.Visible = false;
            LblExceptionLanguage.Visible = false;
            LblExceptionPublisher.Visible = false;
            LblExceptionQuantity.Visible = false;
            LblExceptionShelve.Visible = false;
        }

        private void BindComboCategory()
        {
            Category category = new Category();
            this.ListCategory.DataSource = category.Categories();
            this.ListCategory.DataTextField = "Category";
            this.ListCategory.DataValueField = "CategoryId";
            this.ListCategory.DataBind();
            this.ListCategory.Items.Insert(0, new ListItem("Select Category", "-1"));
            this.ListCategory.Items.Insert(1, new ListItem("Others", "-2"));
        }

        private void BindComboAuthor()
        {
            Author author = new Author();
            this.ListAuthor.DataSource = author.Authors();
            this.ListAuthor.DataTextField = "AuthorName";
            this.ListAuthor.DataValueField = "AuthorId";
            this.ListAuthor.DataBind();
            this.ListAuthor.Items.Insert(0, new ListItem("Select Author", "-1"));
            this.ListAuthor.Items.Insert(1, new ListItem("Others", "-2"));
        }

        private void BindComboLanguage()
        {
            Language language = new Language();
            this.ListLanguage.DataSource = language.Languages();
            this.ListLanguage.DataTextField = "Language";
            this.ListLanguage.DataValueField = "LanguageId";
            this.ListLanguage.DataBind();
            this.ListLanguage.Items.Insert(0, new ListItem("Select Language", "-1"));
            this.ListLanguage.Items.Insert(1, new ListItem("Others", "-2"));
        }

        private void BindComboPublisher()
        {
            Publisher publisher = new Publisher();
            this.ListPublisher.DataSource = publisher.Publishers();
            this.ListPublisher.DataTextField = "Publisher";
            this.ListPublisher.DataValueField = "PublisherId";
            this.ListPublisher.DataBind();
            this.ListPublisher.Items.Insert(0, new ListItem("Select Publisher", "-1"));
            this.ListPublisher.Items.Insert(1, new ListItem("Others", "-2"));
        }

        private void BindComboShelve()
        {
            Shelve shelve = new Shelve();
            this.ListShelve.DataSource = shelve.Shelves();
            this.ListShelve.DataTextField = "Shelve";
            this.ListShelve.DataValueField = "ShelveId";
            this.ListShelve.DataBind();
            this.ListShelve.Items.Insert(0, new ListItem("Select Shelve", "-1"));
        }

        private void BindComboCabinet()
        {
            Cabinet cabinet = new Cabinet();
            this.ListCabinet.DataSource = cabinet.Cabinets();
            this.ListCabinet.DataTextField = "Cabinet";
            this.ListCabinet.DataValueField = "CabinetId";
            this.ListCabinet.DataBind();
            this.ListCabinet.Items.Insert(0, new ListItem("Select Cabinet", "-1"));
        }

        protected void BtnFind_Click(object sender, EventArgs e)
        {
            BookId =  int.Parse(TxtId.Text);
            //exist book id validation

            BooksModel bookmodel = new BooksModel();
            Books book = new Books();
            bookmodel = book.Find(BookId);

            if(bookmodel !=null)
            {
                TxtBookName.Text = bookmodel.BookName;
                ListCategory.SelectedValue = bookmodel.CategoryId.ToString();
                ListAuthor.SelectedValue = bookmodel.AuthorId.ToString();
                ListPublisher.SelectedValue = bookmodel.PublisherId.ToString();
                TxtBookPages.Text = bookmodel.BookPages.ToString();
                TxtQty.Text = bookmodel.Quantity.ToString();
                ListLanguage.SelectedValue = bookmodel.LanguageId.ToString();
                ListShelve.SelectedValue = bookmodel.ShelveId.ToString();
                ListCabinet.SelectedValue = bookmodel.CabinetId.ToString();
            }
            else
            {
                LblExceptionId.Text = "Invalid Book Id, Data not Found";
                LblExceptionId.Visible = true;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BookId = int.Parse(TxtId.Text);

            if (string.IsNullOrEmpty(TxtBookName.Text))
            {
                LblExceptionBookName.Text = "Book Name cannot be NULL";
                LblExceptionBookName.Visible = true;
                return;
            }

            #region ValidateCategory
            //Category
            int CategoryId;

            if (ListCategory.SelectedValue == "-1")
            {
                LblExceptionCategory.Text = "Invalid Category Selected";
                LblExceptionCategory.Visible = true;
                return;
            }
            else if (ListCategory.SelectedValue == "-2")
            {
                string NewCategory = TxtCategory.Text;


                if (string.IsNullOrEmpty(NewCategory))
                {
                    LblExceptionNewCategory.Text = "Category cannot be NULL.";
                    LblExceptionNewCategory.Visible = true;
                    return;
                }
                else
                {
                    Category category = new Category();
                    bool exist = false;

                    CategoryModel catg;


                    exist = category.Exist(NewCategory);

                    if (!exist)
                    {
                        //Add Category
                        catg = new CategoryModel();
                        catg.Category = NewCategory;


                        CategoryId = category.Add(catg);

                        if (CategoryId <= 0)
                        {
                            LblExceptionNewCategory.Text = "New Category cannot be created";
                            LblExceptionNewCategory.Visible = true;
                            return;
                        }

                        //get id
                        //catg = category.Find(NewCategory);
                        //CategoryId = catg.CategoryId;

                    }
                    else
                    {
                        LblExceptionNewCategory.Text = "Category already exists.";
                        LblExceptionNewCategory.Visible = true;
                        return;
                    }
                }
            }
            else
            {
                CategoryId = int.Parse(ListCategory.SelectedValue);
            }
            #endregion

            #region ValidateAuthor
            //Author
            int AuthorId;

            if (ListAuthor.SelectedValue == "-1")
            {
                LblExceptionAuthor.Text = "Invalid Author Selected";
                LblExceptionAuthor.Visible = true;
                return;
            }
            else if (ListAuthor.SelectedValue == "-2")
            {
                string NewAuthor = TxtAuthor.Text;


                if (string.IsNullOrEmpty(NewAuthor))
                {
                    LblExceptionNewAuthor.Text = "Author cannot be NULL.";
                    LblExceptionNewAuthor.Visible = true;
                    return;
                }
                else
                {
                    Author author = new Author();
                    bool exist = false;

                    AuthorModel authorModel;


                    exist = author.Exist(NewAuthor);

                    if (!exist)
                    {
                        //Add Author
                        authorModel = new AuthorModel();
                        authorModel.AuthorName = NewAuthor;


                        AuthorId = author.Add(authorModel);

                        if (AuthorId <= 0)
                        {
                            LblExceptionNewAuthor.Text = "New Author cannot be created";
                            LblExceptionNewAuthor.Visible = true;
                            return;
                        }

                    }
                    else
                    {
                        LblExceptionNewAuthor.Text = "Author already exists.";
                        LblExceptionNewAuthor.Visible = true;
                        return;
                    }
                }
            }
            else
            {
                AuthorId = int.Parse(ListAuthor.SelectedValue);
            }
            #endregion

            #region ValidatePublisher
            //Publisher
            int PublisherId;

            if (ListPublisher.SelectedValue == "-1")
            {
                LblExceptionPublisher.Text = "Invalid Publisher Selected";
                LblExceptionPublisher.Visible = true;
                return;
            }
            else if (ListPublisher.SelectedValue == "-2")
            {
                string NewPublisher = TxtPublisher.Text;


                if (string.IsNullOrEmpty(NewPublisher))
                {
                    LblExceptionNewPublisher.Text = "Publisher cannot be NULL.";
                    LblExceptionNewPublisher.Visible = true;
                    return;
                }
                else
                {
                    Publisher Publisher = new Publisher();
                    bool exist = false;

                    PublisherModel PublisherModel;


                    exist = Publisher.Exist(NewPublisher);

                    if (!exist)
                    {
                        //Add Publisher
                        PublisherModel = new PublisherModel();
                        PublisherModel.Publisher = NewPublisher;


                        PublisherId = Publisher.Add(PublisherModel);

                        if (PublisherId <= 0)
                        {
                            LblExceptionNewPublisher.Text = "New Publisher cannot be created";
                            LblExceptionNewPublisher.Visible = true;
                            return;
                        }

                    }
                    else
                    {
                        LblExceptionNewPublisher.Text = "Publisher already exists.";
                        LblExceptionNewPublisher.Visible = true;
                        return;
                    }
                }
            }
            else
            {
                PublisherId = int.Parse(ListPublisher.SelectedValue);
            }
            #endregion


            if (ListLanguage.SelectedValue == "-1")
            {
                LblExceptionLanguage.Text = "Invalid Language Selected";
                LblExceptionLanguage.Visible = true;
                return;
            }

            if (string.IsNullOrEmpty(TxtBookPages.Text))
            {
                LblExceptionBookPages.Text = "Book Pages cannot be NULL";
                LblExceptionBookPages.Visible = true;
                return;
            }

            if (ListCabinet.SelectedValue == "-1")
            {
                LblExceptionCabinet.Text = "Invalid Cabinet Selected";
                LblExceptionCabinet.Visible = true;
                return;
            }

            if (ListShelve.SelectedValue == "-1")
            {
                LblExceptionShelve.Text = "Invalid Shelve Selected";
                LblExceptionShelve.Visible = true;
                return;
            }


            BooksModel book = new BooksModel();

            book.BookName = TxtBookName.Text;
            book.CategoryId = CategoryId;
            book.AuthorId = AuthorId;
            book.PublisherId = PublisherId;
            book.LanguageId = int.Parse(ListLanguage.SelectedValue);
            book.BookPages = int.Parse(TxtBookPages.Text);

            if (string.IsNullOrEmpty(TxtQty.Text))
            {
                book.Quantity = 0;
            }
            else
            {
                book.Quantity = int.Parse(TxtQty.Text);
            }

            book.CabinetId = int.Parse(ListCabinet.SelectedValue);
            book.ShelveId = int.Parse(ListShelve.SelectedValue);

            Books NewBook = new Books();

            try
            {
                NewBook.Update(book, BookId);
            }
            catch (NullReferenceException)
            {
                LblException.Text = "Form Values cannot be NULL..";
            }
            catch (IndexOutOfRangeException)
            {
                LblException.Text = "DropDown values cannot be NULL...";
            }
            catch (Exception ex)
            {
                LblException.Text = ex.Message;
            }

            Response.Redirect("BooksDetail.aspx");
        }
    }
}