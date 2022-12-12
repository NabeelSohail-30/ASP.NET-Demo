﻿using CsharpWebAppDemo.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo.DataGrid
{
    public partial class WebForm24 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindRepeater();
        }

        private void BindRepeater()
        {
            Author author = new Author();
            Repeater1.DataSource = author.GetAllAuthors();
            Repeater1.DataBind();
        }
    }
}