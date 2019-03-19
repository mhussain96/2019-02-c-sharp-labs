using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NorthwindDatabase.Models;

namespace NorthwindDatabase.Pages
{
    public class CustomersModel : PageModel
    {
        public List<Customers> customers = new List<Customers>();
        [BindProperty]
        public Customers customer { get; set; }

        private Northwind db;
        public CustomersModel(Northwind injectedContext)
        {
            db = injectedContext;
        }

        //HTTP GET REQUEST
        public void OnGet()
        {
            ViewData["Title"] = "List of Northwind Customers";
            customers = db.Customers.OrderBy(c => c.ContactName).ToList();
        }

        
    }
}