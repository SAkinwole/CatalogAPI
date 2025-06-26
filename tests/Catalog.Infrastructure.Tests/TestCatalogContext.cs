using Catalog.Domain.Entities;
using Catalog.Infrastructure.Tests.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Infrastructure.Tests
{
    public class TestCatalogContext : CatalogContext
    {
        public TestCatalogContext(DbContextOptions<CatalogContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Seed<Item>("Data/item.json")
                        .Seed<Artist>("Data/artist.json")
                        .Seed<Genre>("Data/genre.json");

        }
    }
}