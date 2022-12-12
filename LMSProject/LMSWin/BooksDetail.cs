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
    public partial class BooksDetail : Form
    {
        public BooksDetail()
        {
            InitializeComponent();
        }

        private void BooksDetail_Load(object sender, EventArgs e)
        {
            BindComboAuthor();
            BindComboCatg();
            BindComboPublisher();
            BindComboLanguage();
            BindBooksGrid();
        }

        private void BindBooksGrid()
        {
            Books book = new Books();
            this.GridBooks.DataSource = book.BooksAll();
            //this.GridBooks.DataBind();
        }

        private void BindComboCatg()
        {
            Category category = new Category();

            this.ListCategory.ValueMember = "CategoryId";
            this.ListCategory.DisplayMember = "Category";
            this.ListCategory.DataSource = category.Categories();
        }

        private void BindComboAuthor()
        {
            Author author = new Author();

            this.ListAuthor.ValueMember = "AuthorId";
            this.ListAuthor.DisplayMember = "AuthorName";
            this.ListAuthor.DataSource = author.Authors();
           
        }

        private void BindComboPublisher()
        {
            Publisher publisher = new Publisher();

            this.ListPublisher.ValueMember = "PublisherId";
            this.ListPublisher.DisplayMember = "Publisher";
            this.ListPublisher.DataSource = publisher.Publishers();

        }

        private void BindComboLanguage()
        {
            Language language = new Language();

            this.ListLanguage.ValueMember = "LanguageId";
            this.ListLanguage.DisplayMember = "Language";
            this.ListLanguage.DataSource = language.Languages();

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            BooksDetailAdd form = new BooksDetailAdd();
            form.Show();
        }
    }
}
