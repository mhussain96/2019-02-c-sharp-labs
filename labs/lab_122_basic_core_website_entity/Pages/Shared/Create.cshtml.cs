using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using lab_122_basic_core_website_entity.Models;
using lab_122_basic_core_website_entity.Pages;

namespace lab_122_basic_core_website_entity.Pages.Shared
{
    public class CreateModel : PageModel
    {
        private readonly lab_122_basic_core_website_entity.Models.lab_122_basic_core_website_entityContext _context;

        public CreateModel(lab_122_basic_core_website_entity.Models.lab_122_basic_core_website_entityContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Customer Customer { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Customer.Add(Customer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}