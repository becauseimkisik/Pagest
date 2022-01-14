using Pagest.Application.Interfaces;
using Pagest.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Pagest.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<PagestContext>(opt =>
                opt.UseNpgsql(configuration.GetConnectionString("PagestConnectionString"), b =>
                    b.MigrationsAssembly(typeof(PagestContext).Assembly.FullName)));

            service.AddScoped<IPagestContext>(provider => provider.GetService<PagestContext>());
        }
    }
}
