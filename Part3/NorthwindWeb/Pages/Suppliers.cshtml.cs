using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NorthwindWeb.Pages
{
    public class SuppliersModel : PageModel
    {
        public IEnumerable<string>Suppliers { get; set; }
        public void OnGet()
        {
            ViewData["Title"] = "Northwind Web Site - Suppliers";
            Suppliers = new[] { "Alpha Co", "Beta Limited", "Gamma Corp" };
        }
    }
}