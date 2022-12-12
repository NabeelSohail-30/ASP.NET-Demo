using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace LMSWin.Models
{
    class Books
    {
        public void Add(BooksModel book)
        {
            Category category = new Category();
            Author author = new Author();
            Language language = new Language();
            Publisher publisher = new Publisher();
            Shelve shelve = new Shelve();
            Cabinet cabinet = new Cabinet();

            //Validations
            if (string.IsNullOrEmpty(book.BookName))
            {
                throw new NullReferenceException();
            }

            if (!category.Exist(book.CategoryId))
            {
                throw new IndexOutOfRangeException();
            }

            if (!author.Exist(book.AuthorId))
            {
                throw new IndexOutOfRangeException();
            }

            if (!language.Exist(book.LanguageId))
            {
                throw new IndexOutOfRangeException();
            }

            if (!publisher.Exist(book.PublisherId))
            {
                throw new IndexOutOfRangeException();
            }

            if (book.BookPages == 0)
            {
                throw new NullReferenceException();
            }

            if (book.Quantity == 0)
            {
                book.Quantity = 1;
            }

            if (!shelve.Exist(book.ShelveId))
            {
                throw new IndexOutOfRangeException();
            }

            if (!cabinet.Exist(book.CabinetId))
            {
                throw new IndexOutOfRangeException();
            }

            string QryStr;
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;
            using (SqlConnection OpenDb = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    //Insert Book
                    QryStr = $"INSERT INTO BooksDetail(BookName, CategoryId, LanguageId, AuthorId, PublisherId, BookPages, Quantity, CabinetId, ShelveId) VALUES ('{book.BookName}', {book.CategoryId}, {book.LanguageId}, {book.AuthorId}, {book.PublisherId}, {book.BookPages}, {book.Quantity}, {book.CabinetId}, {book.ShelveId})";


                    cmd.CommandText = QryStr;
                    cmd.Connection = OpenDb;
                    if(OpenDb.State == System.Data.ConnectionState.Closed)
                    {
                        OpenDb.Open();
                    }
                    cmd.ExecuteScalar();
                }
            }
        }

        public List<BooksModel> BooksAll()
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = "SELECT * FROM BooksDetail";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    DataReader = cmd.ExecuteReader();

                    List<BooksModel> BooksList = new List<BooksModel>();
                    BooksModel book;



                    while (DataReader.Read())
                    {
                        book = new BooksModel();
                        book.BookId = (int)DataReader["BookId"];
                        book.BookName = DataReader["BookName"].ToString();
                        book.CategoryId = (int)DataReader["CategoryId"];
                        //book.Category.CategoryId = (int)DataReader["CategoryId"];
                        //book.Category.Category = "Category01";
                        book.AuthorId = (int)DataReader["AuthorId"];
                        book.PublisherId = (int)DataReader["PublisherId"];
                        book.LanguageId = (int)DataReader["LanguageId"];
                        book.BookPages = (int)DataReader["BookPages"];
                        book.Quantity = (Int16)DataReader["Quantity"];
                        book.CabinetId = (int)DataReader["CabinetId"];
                        book.ShelveId = (int)DataReader["ShelveId"];

                        BooksList.Add(book);
                    }

                    DataReader.Close();

                    return BooksList;
                }
            }
        }

        public BooksModel Find(int pBookId)
        {
            string CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader DataReader;

                    cmd.CommandText = $"SELECT * FROM View_BooksDetailView WHERE (BookId = {pBookId} )";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;

                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    DataReader = cmd.ExecuteReader();

                    BooksModel book;
                    book = new BooksModel();


                    if (DataReader.HasRows)
                    {
                        DataReader.Read();
                        book.BookId = (int)DataReader["BookId"];
                        book.BookName = DataReader["BookName"].ToString();
                        book.CategoryId = (int)DataReader["CategoryId"];
                        book.AuthorId = (int)DataReader["AuthorId"];
                        book.PublisherId = (int)DataReader["PublisherId"];
                        book.LanguageId = (int)DataReader["LanguageId"];
                        book.BookPages = (int)DataReader["BookPages"];
                        book.Quantity = (Int16)DataReader["Quantity"];
                        book.CabinetId = (int)DataReader["CabinetId"];
                        book.ShelveId = (int)DataReader["ShelveId"];

                        book.Category.CategoryId = (int)DataReader["CategoryId"];
                        book.Category.Category = DataReader["Category"].ToString();

                        book.Author.AuthorId = (int)DataReader["AuthorId"];
                        book.Author.AuthorName = DataReader["AuthorName"].ToString();

                        book.Publisher.PublisherId = (int)DataReader["PublisherId"];
                        book.Publisher.Publisher = DataReader["Publisher"].ToString();

                        book.Language.LanguageId = (int)DataReader["LanguageId"];
                        book.Language.Language = DataReader["Language"].ToString();

                        book.Cabinet.CabinetId = (int)DataReader["CabinetId"];
                        book.Cabinet.Cabinet = DataReader["Cabinet"].ToString();

                        book.Shelve.ShelveId = (int)DataReader["ShelveId"];
                        book.Shelve.Shelve = DataReader["Shelve"].ToString();
                    }

                    DataReader.Close();

                    return book;
                }
            }
        }

        public void Update(BooksModel book, int pBookId)
        {
            Category category = new Category();
            Author author = new Author();
            Language language = new Language();
            Publisher publisher = new Publisher();
            Shelve shelve = new Shelve();
            Cabinet cabinet = new Cabinet();

            #region Validations
            if (string.IsNullOrEmpty(book.BookName))
            {
                throw new NullReferenceException();
            }

            if (!category.Exist(book.CategoryId))
            {
                throw new IndexOutOfRangeException();
            }

            if (!author.Exist(book.AuthorId))
            {
                throw new IndexOutOfRangeException();
            }

            if (!language.Exist(book.LanguageId))
            {
                throw new IndexOutOfRangeException();
            }

            if (!publisher.Exist(book.PublisherId))
            {
                throw new IndexOutOfRangeException();
            }

            if (book.BookPages == 0)
            {
                throw new NullReferenceException();
            }

            if (book.Quantity == 0)
            {
                book.Quantity = 1;
            }

            if (!shelve.Exist(book.ShelveId))
            {
                throw new IndexOutOfRangeException();
            }

            if (!cabinet.Exist(book.CabinetId))
            {
                throw new IndexOutOfRangeException();
            }
            #endregion

            string QryStr;
            using (SqlConnection OpenDb = new SqlConnection("Server=NABEELS-WORK;Database=DemoLMS;User Id=Demo;Password=Nabeel30;"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    //Update Book
                    QryStr = $"UPDATE BooksDetail SET BookName = '{book.BookName}', CategoryId = {book.CategoryId}, AuthorId = {book.AuthorId}, PublisherId = {book.PublisherId}, LanguageId = {book.LanguageId}, BookPages = {book.BookPages}, Quantity = {book.Quantity}, CabinetId = {book.CabinetId}, ShelveId = {book.ShelveId} WHERE (BookId = {pBookId})";

                    cmd.CommandText = QryStr;
                    cmd.Connection = OpenDb;
                    if (OpenDb.State == System.Data.ConnectionState.Closed)
                    {
                        OpenDb.Open();
                    }
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int pBookId)
        {
            string QryStr;
            using (SqlConnection OpenDb = new SqlConnection("Server=NABEELS-WORK;Database=DemoLMS;User Id=Demo;Password=Nabeel30;"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    QryStr = $"DELETE BooksDetail WHERE (BookId = {pBookId})";

                    cmd.CommandText = QryStr;
                    cmd.Connection = OpenDb;
                    if (OpenDb.State == System.Data.ConnectionState.Closed)
                    {
                        OpenDb.Open();
                    }
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
