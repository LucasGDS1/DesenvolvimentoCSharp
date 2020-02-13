using Microsoft.EntityFrameworkCore;
using SalesWebMvcEst.Models;

namespace SalesWebMvcEst.Data
{
    public class SalesWebMvcEstContext : DbContext
    {
        public SalesWebMvcEstContext (DbContextOptions<SalesWebMvcEstContext> options)
            : base(options)
        {

        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}
