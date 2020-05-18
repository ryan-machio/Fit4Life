using Microsoft.EntityFrameworkCore;

namespace Fit4Life.Models.Data
{
    public class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> options)
            : base(options)
        {
        }

        public DbSet<Clients> Clients { get; set; }
    }
}