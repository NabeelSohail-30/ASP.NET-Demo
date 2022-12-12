using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CsharpWebAppDemo.Database.Models
{
    public class ListCityModel
    {
        public int CityId { get; set; }
        public string City { get; set; }
        public int CountryId { get; set; }
        public ListCountryModel Country { get; set; }
    }
}