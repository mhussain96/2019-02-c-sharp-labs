using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using lab_122_basic_core_website_entity.Pages;

namespace lab_122_basic_core_website_entity
{
    public class CreateModel : PageModel
    {
        private readonly lab_122_basic_core_website_entity.Pages.Northwind _context;

        public CreateModel(lab_122_basic_core_website_entity.Pages.Northwind context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Categories.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}