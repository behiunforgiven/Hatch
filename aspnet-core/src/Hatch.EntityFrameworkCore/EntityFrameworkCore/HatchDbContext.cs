using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Hatch.Authorization.Roles;
using Hatch.Authorization.Users;
using Hatch.MultiTenancy;

namespace Hatch.EntityFrameworkCore
{
    public class HatchDbContext : AbpZeroDbContext<Tenant, Role, User, HatchDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public HatchDbContext(DbContextOptions<HatchDbContext> options)
            : base(options)
        {
        }
    }
}
