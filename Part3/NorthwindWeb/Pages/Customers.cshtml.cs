using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Packt.CS7;

namespace NorthwindWeb.Pages
{
    public class CustomersModel : PageModel
    {
        private Northwind db;
        public Dictionary<string, IEnumerable<Customer>> CustomersByCountry { get; set; } = new Dictionary<string, IEnumerable<Customer>>();
        //public IEnumerable<string> Countries { get; set; }

        public CustomersModel(Northwind injectedContext)
        {
            db = injectedContext;
        }

        public void OnGet()
        {
            ViewData["Title"] = "Customers";
            IEnumerable<string> countries = db.Customers.Select(c => c.Country).Distinct().OrderBy(countryName => countryName).ToArray();
            foreach (var country in countries)
            {
                IEnumerable<Customer> customers = db.Customers.Where(c => c.Country == country).OrderBy(c => c.ContactName).ToArray();
                CustomersByCountry.Add(country, customers);
            }
        }
    }
}