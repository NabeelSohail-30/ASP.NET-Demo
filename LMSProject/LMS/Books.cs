using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;

namespace LMS
{
    public class Books
    {
        //private StringBuilder exception = new StringBuilder($"Exception List: {Environment.NewLine}");
        //private bool exceptionFound = false;

        public int Add(BooksModel book)
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
                //exceptionFound = true;
                //exception.Append($"Book Name cannot be NULL {Environment.NewLine}");
                //throw new Exception("Book Name cannot be NULL");
                throw new NullReferenceException();
            }

            if (!category.Exist(book.CategoryId))
            {
                throw new IndexOutOfRangeException();
            }

            //if (exceptionFound)
            //{
            //    throw new Exception(exception.ToString());
            //}

            //Validate book.AuthorId
            //1. Check if book.AuthorId exist or not in the Table ListAuthor
            //Author.Find(book.AuthorId) - Returns Single Author Object
            //Author.Find(book.AuthorId,0) - Returns True / False
            //if(!Author.find(book.authorid,0))
            //throw new IndexOutOfRangeException();

            if (!author.Exist(book.AuthorId))
            {
                throw new IndexOutOfRangeException();
            }

            if(!language.Exist(book.LanguageId))
            {
                throw new IndexOutOfRangeException();
            }

            if(!publisher.Exist(book.PublisherId))
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
            using (SqlConnection OpenDb = new SqlConnection("Server=NABEELS-WORK;Database=DemoLMS;User Id=Demo;Password=Nabeel30;"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    //Insert Book
                    QryStr = $"INSERT INTO BooksDetail(BookName, CategoryId, LanguageId, AuthorId, PublisherId, BookPages, Quantity, CabinetId, ShelveId) VALUES ('{book.BookName}', {book.CategoryId}, {book.LanguageId}, {book.AuthorId}, {book.PublisherId}, {book.BookPages}, {book.Quantity}, {book.CabinetId}, {book.ShelveId})";


                    cmd.CommandText = QryStr;
                    cmd.Connection = OpenDb;
                    if (OpenDb.State == System.Data.ConnectionState.Closed)
                    {
                        OpenDb.Open();
                    }
                    int rows = cmd.ExecuteNonQuery();
                    return rows;
                }
            }
        }

        public int Update(BooksModel book, int pBookId)
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
                    if(OpenDb.State == System.Data.ConnectionState.Closed)
                    {
                        OpenDb.Open();
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public int Delete(int pBookId)
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
                    return cmd.ExecuteNonQuery();
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
                        book.Category.CategoryId = (int)DataReader["CategoryId"];
                        book.Category.Category = "Category01";
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

                    BooksModel book = null;

                    if (DataReader.HasRows)
                    {
                        book = new BooksModel();
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

                        //Category category = new Category();
                        //book.Category = category.Find(book.CategoryId);
                        book.Category.CategoryId = (int)DataReader["CategoryId"];
                        book.Category.Category = DataReader["Category"].ToString();

                        book.Author.AuthorId = (int)DataReader["AuthorId"];
                        book.Author.AuthorName = DataReader["AuthorName"].ToString();

                        book.Publisher.PublisherId = (int)DataReader["PublisherId"];
                        book.Publisher.Publisher = DataReader["Publisher"].ToString();

                        book.Language.LanguageId = (int)DataReader["LanguageId"];
                        book.Language.Language = DataReader["Language"].ToString();

                        book.Cabinet.CabinetId = (int)DataReader["CabinetId"];

                        if(DataReader["Cabinet"] == DBNull.Value)
                        {
                            book.Cabinet.Cabinet = -1;
                        }
                        else
                        { 
                        book.Cabinet.Cabinet = (int)DataReader["Cabinet"];
                        }

                        book.Shelve.ShelveId = (int)DataReader["ShelveId"];

                        if (DataReader["Shelve"] == DBNull.Value)
                        {
                            book.Shelve.Shelve = -1;
                        }
                        else
                        {
                            book.Shelve.Shelve = (int)DataReader["Shelve"];
                        }
                        
                    }

                    DataReader.Close();

                    return book;
                }
            }
        }

    }
}