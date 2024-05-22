using DIPatternDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DIPatternDemo.Data
{
    public class ApplicationDbContext : DbContext
    { 
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
       {

       }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Book> Books { get; set; }
        
    }
}
