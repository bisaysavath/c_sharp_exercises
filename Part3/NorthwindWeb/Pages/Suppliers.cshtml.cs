using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using Packt.CS7;
using Microsoft.AspNetCore.Mvc;

namespace NorthwindWeb.Pages
{
    public class SuppliersModel : PageModel
    {
        private Northwind db;
        public IEnumerable<string>Suppliers { get; set; }
        [BindProperty]
        public Supplier Supplier { get; set; }

        public SuppliersModel(Northwind injectedContext)
        {
            db = injectedContext;
        }

        public void OnGet()
        {
            ViewData["Title"] = "Northwind Web Site - Suppliers";
            Suppliers = db.Suppliers.Select(s => s.CompanyName).ToArray();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                db.Suppliers.Add(Supplier);
                db.SaveChanges();
                return RedirectToPage("/suppliers");
            }

            return Page();
        }
    }
}