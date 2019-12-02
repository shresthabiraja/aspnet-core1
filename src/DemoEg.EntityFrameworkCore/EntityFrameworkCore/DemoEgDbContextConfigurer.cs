using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace DemoEg.EntityFrameworkCore
{
    public static class DemoEgDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DemoEgDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DemoEgDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
