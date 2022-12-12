using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS;

namespace LMSWin
{
    public partial class BooksDetailEdit : Form
    {
        int BookId;
        public BooksDetailEdit()
        {
            InitializeComponent();
        }

        private void BooksDetailEdit_Load(object sender, EventArgs e)
        {
            BindComboAuthor();
            BindComboCatg();
            BindComboPublisher();
            BindComboLanguage();
            BindComboShelve();
            BindComboCabinet();
        }

        private void BindComboCabinet()
        {
            Cabinet cabinet = new Cabinet();

            List<CabinetModel> CabinetList = cabinet.Cabinets();
            //CabinetList.Insert(0, new CabinetModel() { CabinetId = -1, Cabinet = "Select Cabinet" });


            this.ListCabinet.ValueMember = "CabinetId";
            this.ListCabinet.DisplayMember = "Cabinet";
            this.ListCabinet.DataSource = CabinetList;
        }

        private void BindComboShelve()
        {
            Shelve shelve = new Shelve();

            List<ShelveModel> ShelveList = shelve.Shelves();
            //ShelveList.Insert(0, new ShelveModel() { ShelveId = -1, Shelve = "Select Shelve" });

            this.ListShelve.ValueMember = "ShelveId";
            this.ListShelve.DisplayMember = "Shelve";
            this.ListShelve.DataSource = ShelveList;
        }

        private void BindComboCatg()
        {
            Category Category = new Category();

            List<CategoryModel> CategoryList = Category.Categories();
            CategoryList.Insert(0, new CategoryModel() { CategoryId = -1, Category = "Select Category" });
            CategoryList.Insert(1, new CategoryModel() { CategoryId = -2, Category = "Others <Not in the List>" });


            this.ListCategory.ValueMember = "CategoryId";
            this.ListCategory.DisplayMember = "Category";
            this.ListCategory.DataSource = CategoryList;


        }

        private void BindComboAuthor()
        {
            Author author = new Author();

            List<AuthorModel> authorList = author.Authors();
            authorList.Insert(0, new AuthorModel() { AuthorId = -1, AuthorName = "Select Author" });
            authorList.Insert(1, new AuthorModel() { AuthorId = -2, AuthorName = "Others <Not in the List>" });

            this.ListAuthor.ValueMember = "AuthorId";
            this.ListAuthor.DisplayMember = "AuthorName";
            this.ListAuthor.DataSource = authorList;

        }

        private void BindComboPublisher()
        {
            Publisher publisher = new Publisher();

            List<PublisherModel> publisherList = publisher.Publishers();
            publisherList.Insert(0, new PublisherModel() { PublisherId = -1, Publisher = "Select Publisher" });
            publisherList.Insert(1, new PublisherModel() { PublisherId = -2, Publisher = "Others <Not in the List>" });

            this.ListPublisher.ValueMember = "PublisherId";
            this.ListPublisher.DisplayMember = "Publisher";
            this.ListPublisher.DataSource = publisherList;

        }

        private void BindComboLanguage()
        {
            Language language = new Language();

            List<LanguageModel> languageList = language.Languages();
            languageList.Insert(0, new LanguageModel() { LanguageId = -1, Language = "Select Language" });


            this.ListLanguage.ValueMember = "LanguageId";
            this.ListLanguage.DisplayMember = "Language";
            this.ListLanguage.DataSource = languageList;

        }

        private void ListCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (ListCategory.SelectedValue.ToString() == "-2")
            //{
            //    TxtNewCatg.Enabled = true;
            //}
            //else
            //{
            //    TxtNewCatg.Enabled = false;
            //}
        }

        private void ListAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (ListAuthor.SelectedValue.ToString() == "-2")
            //{
            //    TxtNewAuthor.Enabled = true;
            //}
            //else
            //{
            //    TxtNewAuthor.Enabled = false;
            //}
        }

        private void ListPublisher_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (ListPublisher.SelectedValue.ToString() == "-2")
            //{
            //    TxtNewPublisher.Enabled = true;
            //}
            //else
            //{
            //    TxtNewPublisher.Enabled = false;
            //}
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            BookId = int.Parse(TxtId.Text);

            if (string.IsNullOrEmpty(TxtBookName.Text))
            {
                MessageBox.Show("Book Name cannot be NULL", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #region ValidateCategory
            //Category
            int CategoryId;

            if (ListCategory.SelectedValue.ToString() == "-1")
            {
                MessageBox.Show("Invalid Category Selected", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (ListCategory.SelectedValue.ToString() == "-2")
            {
                string NewCategory = TxtNewCatg.Text;


                if (string.IsNullOrEmpty(NewCategory))
                {
                    MessageBox.Show("Category cannot be NULL", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            MessageBox.Show("New Category cannnot be created", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }


                    }
                    else
                    {
                        MessageBox.Show("Category Already exists", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                CategoryId = (int)ListCategory.SelectedValue;
            }
            #endregion

            #region ValidateAuthor
            //Author
            int AuthorId;

            if (ListAuthor.SelectedValue.ToString() == "-1")
            {
                MessageBox.Show("Invalid Author Selected", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (ListAuthor.SelectedValue.ToString() == "-2")
            {
                string NewAuthor = TxtNewAuthor.Text;

                if (string.IsNullOrEmpty(NewAuthor))
                {
                    MessageBox.Show("Author Cannot be Null", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            MessageBox.Show("New Author cannot be created", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Author already exists", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                AuthorId = (int)(ListAuthor.SelectedValue);
            }
            #endregion

            #region ValidatePublisher
            //Publisher
            int PublisherId;

            if (ListPublisher.SelectedValue.ToString() == "-1")
            {
                MessageBox.Show("Invalid Publisher Selected", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (ListPublisher.SelectedValue.ToString() == "-2")
            {
                string NewPublisher = TxtNewPublisher.Text;


                if (string.IsNullOrEmpty(NewPublisher))
                {
                    MessageBox.Show("Publisher cannot be NULL", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            MessageBox.Show("New Publisher cannot be created", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Publisher already exists", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                PublisherId = (int)(ListPublisher.SelectedValue);
            }
            #endregion

            if (ListLanguage.SelectedValue.ToString() == "-1")
            {
                MessageBox.Show("Invalid Language Selected", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(TxtBookPages.Text))
            {
                MessageBox.Show("Book Pages cannot be NULL", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ListCabinet.SelectedValue.ToString() == "-1")
            {
                MessageBox.Show("Invalid Cabinet Selected", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ListShelve.SelectedValue.ToString() == "-1")
            {
                MessageBox.Show("Invalid Shelve Selected", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BooksModel book = new BooksModel();

            book.BookName = TxtBookName.Text;
            book.CategoryId = CategoryId;
            book.AuthorId = AuthorId;
            book.PublisherId = PublisherId;
            book.LanguageId = (int)ListLanguage.SelectedValue;


            if (string.IsNullOrEmpty(TxtBookPages.Text))
            {
                book.BookPages = 0;
            }
            else
            {
                book.BookPages = int.Parse(TxtBookPages.Text);
            }

            if (string.IsNullOrEmpty(TxtQty.Text))
            {
                book.Quantity = 0;
            }
            else
            {
                book.Quantity = int.Parse(TxtQty.Text);
            }

            book.CabinetId = (int)ListCabinet.SelectedValue;
            book.ShelveId = (int)ListShelve.SelectedValue;

            Books NewBook = new Books();

            try
            {
                NewBook.Update(book,BookId);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Form Values cannot be NULL", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Drop Down value cannot be NULL", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BooksDetail FormBookDetail = new BooksDetail();
            this.Hide();
            FormBookDetail.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookId = int.Parse(TxtId.Text);

            BooksModel bookmodel = new BooksModel();
            Books book = new Books();
            bookmodel = book.Find(BookId);

            TxtBookName.Text = bookmodel.BookName;
            ListCategory.SelectedValue = bookmodel.CategoryId;
            ListAuthor.SelectedValue = bookmodel.AuthorId;
            ListPublisher.SelectedValue = bookmodel.PublisherId;
            TxtBookPages.Text = bookmodel.BookPages.ToString();
            TxtQty.Text = bookmodel.Quantity.ToString();
            ListLanguage.SelectedValue = bookmodel.LanguageId;
            ListShelve.SelectedValue = bookmodel.ShelveId;
            ListCabinet.SelectedValue = bookmodel.CabinetId;
        }
    }
}
