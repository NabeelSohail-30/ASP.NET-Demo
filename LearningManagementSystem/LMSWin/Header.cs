using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMSWin
{
    public partial class Header : UserControl
    {
        public Header()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            BooksDetail FormBook = new BooksDetail();
            
            Panel ParentPanel = (Panel)this.Parent;
            Form ParentForm = (Form)ParentPanel.Parent;
            ParentForm.Hide();
            FormBook.Show();
        }

        private void editBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BooksDetailEdit FormBook = new BooksDetailEdit();

            Panel ParentPanel = (Panel)this.Parent;
            Form ParentForm = (Form)ParentPanel.Parent;
            ParentForm.Hide();
            FormBook.Show();
        }

        private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BooksDetailView FormBook = new BooksDetailView();

            Panel ParentPanel = (Panel)this.Parent;
            Form ParentForm = (Form)ParentPanel.Parent;
            ParentForm.Hide();
            FormBook.Show();
        }

        private void deleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BooksDetailDelete FormBook = new BooksDetailDelete();

            Panel ParentPanel = (Panel)this.Parent;
            Form ParentForm = (Form)ParentPanel.Parent;
            ParentForm.Hide();
            FormBook.Show();
        }
    }
}
