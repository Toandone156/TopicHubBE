using Microsoft.EntityFrameworkCore;

namespace TopicHubBE.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
