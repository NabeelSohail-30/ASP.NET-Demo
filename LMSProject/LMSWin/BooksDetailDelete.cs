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
    public partial class BooksDetailDelete : Form
    {
        int BookId;
        public BooksDetailDelete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookId = int.Parse(TxtId.Text);

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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            BookId = int.Parse(TxtId.Text);

            Books NewBook = new Books();
            NewBook.Delete(BookId);

            BooksDetail FormBookDetail = new BooksDetail();
            this.Hide();
            FormBookDetail.Show();
        }
    }
}
