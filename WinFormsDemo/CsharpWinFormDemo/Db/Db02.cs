using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CsharpWinFormDemo.Db
{
    public partial class Db02 : Form
    {
        public Db02()
        {
            InitializeComponent();
        }

        private void Db02_Load(object sender, EventArgs e)
        {
            FillDropDownAuthor();
            FillDropDownAuthor2();
        }

        private void FillDropDownAuthor2()
        {
            //Connect and Open DB
            SqlConnection DBConnection = new SqlConnection();
            DBConnection.ConnectionString = "Server=NABEELS-WORK;Database=DemoLMS;User Id=Demo;Password=Nabeel30;";

            //Build SQL Command
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT AuthorId, AuthorName FROM ListAuthor";
            cmd.Connection = DBConnection;

            //SqlDataReader to store the Result returns by SqlCommand
            SqlDataReader ReaderAuthor;

            DBConnection.Open();
            ReaderAuthor = cmd.ExecuteReader();

            ComboAuthor2.Items.Clear();
            ComboAuthor2.ValueMember = "AuthorId";
            ComboAuthor2.DisplayMember = "AuthorName";

            //Method 1 - Create Object of Class Author & then Add into ComboBox.
            Author AuthorDetail;

            AuthorDetail = new Author(-1, "Select Author");
            ComboAuthor2.Items.Add(AuthorDetail);

            while (ReaderAuthor.Read())
            {
                AuthorDetail = new Author((int)(ReaderAuthor["AuthorId"]), (string)(ReaderAuthor["AuthorName"]));
                ComboAuthor2.Items.Add(AuthorDetail);
            }

            //Method 2 - First Generate List Type & then populate ComboBox from List.
            //List<Author> ListAuthor = new List<Author>();
            //ListAuthor.Add(new Author(-1, "Select Author"));

            //while (ReaderAuthor.Read())
            //{
            //    ListAuthor.Add(new Author((int)(ReaderAuthor["AuthorId"]), (string)(ReaderAuthor["AuthorName"])));
            //}

            //foreach(Author list in ListAuthor)
            //{
            //    ComboAuthor2.Items.Add(list);
            //}

            //ComboAuthor2.Items.AddRange(ListAuthor.ToArray());


            ComboAuthor2.SelectedIndex = 0;
        }

        private void FillDropDownAuthor()
        {
            //Connect and Open DB
            SqlConnection DBConnection = new SqlConnection();
            DBConnection.ConnectionString = "Server=NABEELS-WORK;Database=DemoLMS;User Id=Demo;Password=Nabeel30;";

            //Build SQL Command
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM ListAuthor";
            cmd.Connection = DBConnection;

            //SqlDataReader to store the Result returns by SqlCommand
            SqlDataReader ReaderAuthor;

            DBConnection.Open();
            ReaderAuthor = cmd.ExecuteReader();

            //Add Items in DropDown
            ComboAuthor.Items.Clear();
            ComboAuthor.Items.Add("Select Author");
            while (ReaderAuthor.Read())
            {
                ComboAuthor.Items.Add(ReaderAuthor["AuthorName"]);
            }
            ComboAuthor.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Index = {ComboAuthor.SelectedIndex}, Text = {ComboAuthor.SelectedItem}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Author SelectedAuthor = (Author)(ComboAuthor2.SelectedItem);
            MessageBox.Show($"Index = {ComboAuthor2.SelectedIndex}, Value = {SelectedAuthor.AuthorId}, Text = {SelectedAuthor.AuthorName}");
        }
    }

    public class Author
    {
        public Author(int _AuthorId, string _AuthorName)
        {
            AuthorId = _AuthorId;
            AuthorName = _AuthorName;
        }

        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
    }
}
