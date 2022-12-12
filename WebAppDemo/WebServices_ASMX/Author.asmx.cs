using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebServices_ASMX.Models;

namespace WebServices_ASMX
{
    /// <summary>
    /// Summary description for Author
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    //[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]

    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    public class Author : System.Web.Services.WebService
    {

        [WebMethod(EnableSession = true)]
        public List<AuthorModel> GetAuthors()
        {
            if (Session["NumberOfTimesInvoked"] == null)
            {
                Session["NumberOfTimesInvoked"] = "0";
            }
            Session["NumberOfTimesInvoked"] = int.Parse(Session["NumberOfTimesInvoked"].ToString()) + 1;
            //Session["NumberOfTimesInvoked"] = "45";
            WebServices_ASMX.Models.Author author = new WebServices_ASMX.Models.Author();
            return author.GetAllAuthors();
        }

        [WebMethod (EnableSession = true)]
        public int SessionValue()
        {
            if (Session["NumberOfTimesInvoked"] != null)
                return int.Parse(Session["NumberOfTimesInvoked"].ToString());
            else
                return -1;
        }

        [WebMethod]
        public AuthorModel Find(int id)
        {
            WebServices_ASMX.Models.Author author = new WebServices_ASMX.Models.Author();
            return author.FindById(id);
        }

        [WebMethod (MessageName = "FindAll")]
        public List<AuthorModel> Find(string name)
        {
            WebServices_ASMX.Models.Author author = new WebServices_ASMX.Models.Author();
            return author.FindAll(name);
        }

        [WebMethod]
        public void Delete(int id)
        {
            WebServices_ASMX.Models.Author author = new WebServices_ASMX.Models.Author();
            author.DeleteById(id);
        }

        [WebMethod]
        public void Add(string AuthorName, string Gender, bool Active)
        {
            WebServices_ASMX.Models.Author author = new WebServices_ASMX.Models.Author();
            author.AddAuthor(AuthorName, Gender, Active);
        }

        [WebMethod]
        public string Update()
        {
            return "Record Updated";
        }
    }
}
