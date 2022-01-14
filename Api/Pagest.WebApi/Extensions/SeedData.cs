using Pagest.Infrastructure.Authentication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace Pagest.WebApi.Extensions
{
    public static class SeedData
    {
        public static async Task InitializeBaseUser(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                using var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            }
        }
    }
}
