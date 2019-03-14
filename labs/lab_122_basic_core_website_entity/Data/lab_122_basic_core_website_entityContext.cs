using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lab_122_basic_core_website_entity.Pages;

namespace lab_122_basic_core_website_entity.Models
{
    public class lab_122_basic_core_website_entityContext : DbContext
    {
        public lab_122_basic_core_website_entityContext (DbContextOptions<lab_122_basic_core_website_entityContext> options)
            : base(options)
        {
        }

        public DbSet<lab_122_basic_core_website_entity.Pages.Customer> Customer { get; set; }
    }
}
