using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace CountryInfoApp.Pages
{
    public class CountryModel : PageModel
    {
        public List<Country> Countries { get; private set; }

        public void OnGet()
        {
            Countries = new List<Country>
            {
                new Country { Name = "USA", Capital = "Washington, D.C.", Continent = "North America" },
                new Country { Name = "Germany", Capital = "Berlin", Continent = "Europe" },
                new Country { Name = "Japan", Capital = "Tokyo", Continent = "Asia" }
            };
        }
    }

    public class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Continent { get; set; }
    }
}