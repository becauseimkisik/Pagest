using Pagest.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Pagest.Infrastructure.Persistence.Context
{
    public sealed class PagestContext : DbContext, IPagestContext
    {
        public PagestContext(DbContextOptions<PagestContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
