using CarlosAPP.Models;
using Microsoft.EntityFrameworkCore;
namespace CarlosAPP.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ):base (options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        

    }
}
