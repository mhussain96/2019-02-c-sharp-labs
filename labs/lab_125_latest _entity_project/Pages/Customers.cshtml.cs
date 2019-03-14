using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lab_125_latest_entity_project.Models;

namespace lab_125_latest_entity_project.Pages
{
    public class CustomersModel : PageModel
    {
        public List<Customer> customers = new List<Customer>();
        [BindProperty]
        public Customer customer { get; set; }

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