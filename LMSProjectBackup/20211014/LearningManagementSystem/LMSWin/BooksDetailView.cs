using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMSWin.Models;

namespace LMSWin
{
    public partial class BooksDetailView : Form
    {
        int BookId;
        public BooksDetailView()
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
    }
}
