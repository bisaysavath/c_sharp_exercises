using Microsoft.AspNetCore.Mvc.RazorPages;
using Packt.CS7;
using System.Linq;

namespace NorthwindWeb.Pages
{
    public class Customer_detailsModel : PageModel
    {
        private Northwind db;
        public Customer Customer { get; set; }

        public Customer_detailsModel(Northwind injectedContext)
        {
            db = injectedContext;
        }

        public void OnGet()
        {
            ViewData["Title"] = "Customer_details";
            string customerID = Request.QueryString.ToString().Remove(0, 12);
            Customer = db.Customers.Where(c => c.CustomerID == customerID).Single();
        }
    }
}