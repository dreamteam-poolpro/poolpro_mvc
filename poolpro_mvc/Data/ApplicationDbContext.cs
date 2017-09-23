using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using poolpro_mvc.Models;
using poolpro_mvc.Models.CustomerViewModels;

namespace poolpro_mvc.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
         {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);  


        }

        // not sure where this is supposed to go, putting it in to OnModelCreating created an error. 
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<WorkOrder> WorkOrders { get; set; }
        public DbSet<LineItem> LineItems { get; set; }
        public DbSet<ServiceTech> ServiceTechs { get; set; }
    }
}
