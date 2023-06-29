using Authorization.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Authorization.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<SalesLeadEntity> SalesLead { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
