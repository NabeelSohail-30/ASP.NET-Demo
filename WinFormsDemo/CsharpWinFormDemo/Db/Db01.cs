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
    public partial class Db01 : Form
    {
        public Db01()
        {
            InitializeComponent();
        }

        private void Db01_Load(object sender, EventArgs e)
        {
            //Connect and Open DB
            SqlConnection DBConnection = new SqlConnection();
            DBConnection.ConnectionString = "Server=NABEELS-WORK;Database=DemoLMS;User Id=Demo;Password=Nabeel30;";

            //Build SQL Command
            SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = System.Data.CommandType.TableDirect;
            cmd.CommandText = "SELECT * FROM ListAuthor";
            cmd.Connection = DBConnection;

            //SqlDataReader to store the Result returns by SqlCommand
            SqlDataReader ReaderAuthor;

            List<string> ListAuthor = new List<string>();
            
            try
            {
                DBConnection.Open();
                ReaderAuthor = cmd.ExecuteReader();

                while (ReaderAuthor.Read())
                {
                    //textBox1.Text = $"Id = {ReaderAuthor["AuthorId"]}, Name = {ReaderAuthor["AuthorName"]} {Environment.NewLine}";
                    ListAuthor.Add($"Id = {ReaderAuthor["AuthorId"]}, Name = {ReaderAuthor["AuthorName"]}");
                }
            }
            catch (Exception ex)
            {
                textBox1.Text = ex.Message;
            }

            textBox1.Lines = ListAuthor.ToArray();
        }
    }
}
