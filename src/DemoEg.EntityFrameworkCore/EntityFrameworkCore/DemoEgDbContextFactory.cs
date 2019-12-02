using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using DemoEg.Configuration;
using DemoEg.Web;

namespace DemoEg.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DemoEgDbContextFactory : IDesignTimeDbContextFactory<DemoEgDbContext>
    {
        public DemoEgDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DemoEgDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DemoEgDbContextConfigurer.Configure(builder, configuration.GetConnectionString(DemoEgConsts.ConnectionStringName));

            return new DemoEgDbContext(builder.Options);
        }
    }
}
