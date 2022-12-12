using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CsharpWebAppDemo.Database
{
    public partial class Db10_Disconnected : System.Web.UI.Page
    {
        string CS;
        DataSet ds;
        SqlDataAdapter da;
        string Query;
        DataRow row;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CS = ConfigurationManager.ConnectionStrings["SqlDbCS"].ConnectionString;
                Query = "SELECT * FROM ListAuthor";

                using (SqlConnection conn = new SqlConnection(CS))
                {
                    ds = new DataSet();
                    da = new SqlDataAdapter(Query, conn);

                    da.Fill(ds);
                    Cache["AuthorData"] = ds;

                    BindGrid();
                }
            }
            else
            {
                ds = new DataSet();
                ds = (DataSet)Cache["AuthorData"];
            }
        }

        private void BindGrid()
        {
            this.GridView1.DataSource = ds;
            this.GridView1.DataBind();
            lblCount.Text = ds.Tables[0].Rows.Count.ToString();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //Create new row
            row = ds.Tables[0].NewRow();

            //Assign Data into the new created row
            row["AuthorName"] = txtAuthor.Text;


            ds.Tables[0].Rows.Add(row);
            Cache["AuthorData"] = ds;
            BindGrid();

        }

        protected void btnRow_Click(object sender, EventArgs e)
        {
            DataRow myRow;
            for(int i=1; i<=5;i++)
            {
                myRow = ds.Tables[0].NewRow();
                myRow["AuthorName"]  = $"New Author {i}";
                ds.Tables[0].Rows.Add(myRow);
            }

            BindGrid();
        }

        protected void btnDBupdate_Click(object sender, EventArgs e)
        {
            ds.AcceptChanges();
        }
    }
}