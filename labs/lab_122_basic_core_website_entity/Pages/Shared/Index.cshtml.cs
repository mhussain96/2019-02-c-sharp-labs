using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lab_122_basic_core_website_entity.Models;
using lab_122_basic_core_website_entity.Pages;

namespace lab_122_basic_core_website_entity.Pages.Shared
{
    public class IndexModel : PageModel
    {
        private readonly lab_122_basic_core_website_entity.Models.lab_122_basic_core_website_entityContext _context;

        public IndexModel(lab_122_basic_core_website_entity.Models.lab_122_basic_core_website_entityContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customer.ToListAsync();
        }
    }
}
