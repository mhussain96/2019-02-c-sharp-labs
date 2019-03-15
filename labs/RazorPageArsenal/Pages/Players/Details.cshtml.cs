using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageArsenal.Models;

namespace RazorPageArsenal.Pages.Players
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPageArsenal.Models.RazorPageArsenalContext _context;

        public DetailsModel(RazorPageArsenal.Models.RazorPageArsenalContext context)
        {
            _context = context;
        }

        public Player Player { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Player = await _context.Player.FirstOrDefaultAsync(m => m.ID == id);

            if (Player == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
