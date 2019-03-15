using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorPageArsenal.Models
{
    public class RazorPageArsenalContext : DbContext
    {
        public RazorPageArsenalContext (DbContextOptions<RazorPageArsenalContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPageArsenal.Models.Player> Player { get; set; }
    }
}
