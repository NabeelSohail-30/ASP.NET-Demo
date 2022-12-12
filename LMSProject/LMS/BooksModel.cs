using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS
{
    public class BooksModel
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; } = new CategoryModel();
        public int LanguageId { get; set; }
        public LanguageModel Language { get; set; } = new LanguageModel();
        public int AuthorId { get; set; }
        public AuthorModel Author { get; set; } = new AuthorModel();
        public int PublisherId { get; set; }
        public PublisherModel Publisher { get; set; } = new PublisherModel();
        public int BookPages { get; set; }
        public int Quantity { get; set; }
        public int CabinetId { get; set; }
        public CabinetModel Cabinet { get; set; } = new CabinetModel();
        public int ShelveId { get; set; }
        public ShelveModel Shelve { get; set; } = new ShelveModel();
    }
}