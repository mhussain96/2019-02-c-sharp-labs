using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NorthwindDatabase.Models
{
    public class NorthwindDatabaseContext : DbContext
    {
        public NorthwindDatabaseContext (DbContextOptions<NorthwindDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<NorthwindDatabase.Models.Customers> Customer { get; set; }
    }
}
