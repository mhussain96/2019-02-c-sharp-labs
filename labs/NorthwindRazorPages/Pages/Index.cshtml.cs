using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NorthwindRazorPages.Models;

namespace NorthwindRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly NorthwindRazorPages.Models.Northwind _context;

        public IndexModel(NorthwindRazorPages.Models.Northwind context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customers.ToListAsync();
        }
    }
}
