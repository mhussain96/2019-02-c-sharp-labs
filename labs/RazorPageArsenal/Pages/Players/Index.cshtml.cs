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
    public class IndexModel : PageModel
    {
        private readonly RazorPageArsenal.Models.RazorPageArsenalContext _context;

        public IndexModel(RazorPageArsenal.Models.RazorPageArsenalContext context)
        {
            _context = context;
        }

        public IList<Player> Player { get;set; }

        public async Task OnGetAsync()
        {
            Player = await _context.Player.ToListAsync();
        }
    }
}
