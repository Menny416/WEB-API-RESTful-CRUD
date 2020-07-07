using API_REST_DEMO_CRUD.Entity;
using Microsoft.EntityFrameworkCore;

namespace API_REST_DEMO_CRUD.Context
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario_API> Usuario_API { get; set; }

    }

}
