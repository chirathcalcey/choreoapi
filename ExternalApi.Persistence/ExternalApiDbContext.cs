using Microsoft.EntityFrameworkCore;

namespace ExternalApi.Persistence
{
    public class ExternalApiDbContext : DbContext
    {
        public ExternalApiDbContext (DbContextOptions<ExternalApiDbContext> options)
            : base(options)
        {
        }

        public DbSet<ExternalApi.Domain.Todo> Todo { get; set; } = default!;
    }
}
