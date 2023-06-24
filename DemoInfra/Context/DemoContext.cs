using DemoDomain.Entities;
using DemoInfra.Mapping;
using Microsoft.EntityFrameworkCore;

namespace DemoInfra.Context
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options) { }


        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>(new UserMap().Configure);
        }
    }
}
