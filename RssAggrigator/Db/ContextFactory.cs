using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace RssAggrigator.Db
{
     public class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            optionsBuilder.UseNpgsql("User ID=postgres; Password=postgres; Database=ytRss2; Server=localhost; Port=5432; Include Error Detail=true;");

            return new Context(optionsBuilder.Options);
        }
    }
}
