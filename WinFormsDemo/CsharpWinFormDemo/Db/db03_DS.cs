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
using System.Configuration;
using System.Data.Common;

namespace CsharpWinFormDemo.Db
{
    public partial class db03_DS : Form
    {
        public db03_DS()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();

        int currentRow = 0;
        
        int TotalRows;
        //int FirstRow;


        private void db03_DS_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
            string QueryStr = "SELECT * FROM ListAuthor";

            using (SqlConnection conn = new SqlConnection(CS))
            {
                SqlDataAdapter da = new SqlDataAdapter(QueryStr, conn);

                da.Fill(ds);

                TotalRows = ds.Tables[0].Rows.Count;

                BindControl();

            }

            //LblRecord.Text = $"Record {currentRow+1} / {TotalRows}";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(currentRow < TotalRows-1)
            {
                currentRow++;
                BindControl();
            }

        }

        private void BindControl()
        {
            TxtAuthorId.Text = ds.Tables[0].Rows[currentRow]["AuthorId"].ToString();
            TxtAuthor.Text = ds.Tables[0].Rows[currentRow]["AuthorName"].ToString();
            LblRecord.Text = $"Record {currentRow + 1} / {TotalRows}";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(currentRow > 0)
            {
                currentRow--;
                BindControl();
            }


        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            currentRow = 0;
            BindControl();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentRow = TotalRows-1;
            BindControl();
        }
    }
}
