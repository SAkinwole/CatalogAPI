using Catalog.Domain;
using Catalog.Domain.Repositories;
using Catalog.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Catalog.API.Extensions
{
    public static class ServicesExtension
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services, WebApplicationBuilder builder)
        {
            services.AddDbContext<CatalogContext>(options =>
                 options.UseSqlServer(
                        builder.Configuration.GetConnectionString("DefaultConnection")));
                        //sqlOptions =>
                        //{
                        //    sqlOptions.MigrationsAssembly(typeof(CatalogContext).Assembly.FullName);
                        //}));

          return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            // Register the repositories
            services.AddScoped<IItemRepository, ItemRepository>();
            services.AddScoped<IUnitOfWork, CatalogContext>();
            return services;
        }
    }
}
