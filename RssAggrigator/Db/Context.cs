
using Microsoft.EntityFrameworkCore;
using RssAggrigator.Entity;

namespace RssAggrigator.Db
{
    public class Context : DbContext
    {
        public DbSet<AppUser> Users {get; set;}
        public Context (DbContextOptions<Context> options) : base(options){

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}