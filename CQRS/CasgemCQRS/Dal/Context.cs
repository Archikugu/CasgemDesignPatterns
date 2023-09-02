using Microsoft.EntityFrameworkCore;

namespace CasgemCQRS.Dal
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-4K38GM2 ; initial catalog = CasgemCQRSDb ;integrated security = true;");
        }
        public DbSet<Product> Products { get; set; }
    }
}
