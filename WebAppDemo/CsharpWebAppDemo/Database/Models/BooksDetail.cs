using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CsharpWebAppDemo.Database.Models
{
    public class BooksDetail
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int CategoryId { get; set; }
        public int LanguageId { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public int BookPages { get; set; }
        public int Quantity { get; set; }
        public int CabinetId { get; set; }
        public int ShelveId { get; set; }

    }
}