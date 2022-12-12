using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CsharpWebAppDemo.Database.Models
{
    public class ListContinentModel
    {
        public int ContinentId { get; set; }
        public string Continent { get; set; }
        public List<ListCountryModel> Countries {
            get
            {
                ListCountryRepo country = new ListCountryRepo();
                return country.FindByContinent(this.ContinentId);
            }
        }
    }
}