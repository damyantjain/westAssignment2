using System;
using Microsoft.EntityFrameworkCore;
using Demo.Models;
namespace Demo.Contexts
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options) { }

        public DbSet<Group> Groups { get; set; }
        public object Login { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
