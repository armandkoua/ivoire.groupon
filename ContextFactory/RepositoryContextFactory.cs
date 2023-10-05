using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Repository;

namespace ivoire.groupon.ContextFactory
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<Repository.RepositoryContext>
    {
        public RepositoryContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<RepositoryContext>()
                .UseSqlServer(configuration.GetConnectionString("sqlConnection"),
                b=> b.MigrationsAssembly("ivoire.groupon"));
            return new RepositoryContext(builder.Options);
        }
    }
}
