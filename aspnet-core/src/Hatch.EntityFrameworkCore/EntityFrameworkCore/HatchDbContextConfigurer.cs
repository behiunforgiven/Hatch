using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Hatch.EntityFrameworkCore
{
    public static class HatchDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HatchDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<HatchDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
