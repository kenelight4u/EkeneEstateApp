using ekeneEstateApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ekeneEstateApp.Data.DatabaseDbContexts.ApplicationDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Property> Properties { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}