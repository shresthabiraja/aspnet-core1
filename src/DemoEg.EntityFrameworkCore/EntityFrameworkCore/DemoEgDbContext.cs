using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DemoEg.Authorization.Roles;
using DemoEg.Authorization.Users;
using DemoEg.MultiTenancy;
using DemoEg.Model;

namespace DemoEg.EntityFrameworkCore
{
    public class DemoEgDbContext : AbpZeroDbContext<Tenant, Role, User, DemoEgDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Task> Tasks { get; set; }
        public DemoEgDbContext(DbContextOptions<DemoEgDbContext> options)
            : base(options)
        {
        }
    }
}
