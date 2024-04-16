using Microsoft.EntityFrameworkCore;
using TechSprint2.Models;

namespace TechSprint2.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> option) : base(option)
        { 

        }
        public DbSet<Customers> Customers { get; set; }
    }
}
