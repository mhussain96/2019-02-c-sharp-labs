using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lab_122_basic_core_website_entity.Pages;

namespace lab_122_basic_core_website_entity
{
    public class IndexModel : PageModel
    {
        private readonly lab_122_basic_core_website_entity.Pages.Northwind _context;

        public IndexModel(lab_122_basic_core_website_entity.Pages.Northwind context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Categories.ToListAsync();
        }
    }
}
