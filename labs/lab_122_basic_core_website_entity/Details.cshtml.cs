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
    public class DetailsModel : PageModel
    {
        private readonly lab_122_basic_core_website_entity.Pages.Northwind _context;

        public DetailsModel(lab_122_basic_core_website_entity.Pages.Northwind context)
        {
            _context = context;
        }

        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Categories.FirstOrDefaultAsync(m => m.CategoryID == id);

            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
