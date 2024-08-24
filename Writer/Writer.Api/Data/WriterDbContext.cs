using Microsoft.EntityFrameworkCore;

namespace Writer.Api.Data
{
    public class WriterDbContext : DbContext
    {
        public WriterDbContext(DbContextOptions<WriterDbContext> options) : base(options)
        {
        }

        public DbSet<Models.Writer> Writers { get; set; }
    }
}
