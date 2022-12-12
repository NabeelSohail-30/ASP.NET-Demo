using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CsharpWebAppDemo.Database.Models
{
    public class ListCountryModel
    {
        public int CountryId { get; set; }
        public string Country { get; set; }
        public int ContinentId { get; set; }
        public ListContinentModel Continent { get; set; }
    }
}