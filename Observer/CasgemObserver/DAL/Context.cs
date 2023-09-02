using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CasgemObserver.DAL
{
    public class Context : IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-4K38GM2 ; initial catalog = CasgemObserverDb ;integrated security = true; TrustServerCertificate=True");
        }
        public DbSet<WelcomeMessage> WelcomeMessages { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<UserProcess> UserProcesses { get; set; }
    }
}

