using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pagest.Infrastructure.Authentication.Context;
using Pagest.Infrastructure.Persistence.Context;

namespace Pagest.WebApi.Extensions
{
    public static class MigrationManager
    {
        public static IHost MigrateContexts(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using (var authContext = scope.ServiceProvider.GetRequiredService<AuthContext>())
                {
                    authContext.Database.Migrate();
                }

                using (var PagestContext = scope.ServiceProvider.GetRequiredService<PagestContext>())
                {
                    PagestContext.Database.Migrate();
                }
            }
            return host;
        }
    }
}
