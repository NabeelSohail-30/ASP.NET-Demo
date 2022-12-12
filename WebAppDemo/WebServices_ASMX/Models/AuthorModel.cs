using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServices_ASMX.Models
{
    public class AuthorModel
    { 
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string Gender { get; set; }
        public bool Active { get; set; }
        public string ImageURL { get; set; }
        public double TotalPrice { get; set; }
        public int Qty { get; set; }
    }
}