using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CArch.Application.Services;
using CArch.Domain.Repositories;
using CArch.Infrastructure.EF.Contexts;
using CArch.Infrastructure.EF.Options;
using CArch.Infrastructure.EF.Repositories;
using CArch.Infrastructure.EF.Services;
using CArch.Shared.Options;

namespace CArch.Infrastructure.EF
{
    internal static class Extensions
    {
        public static IServiceCollection AddPostgres(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAuthorRepository, PostgresAuthorRepository>();
            services.AddScoped<IAuthorReadService, PostgresAuthorReadService>();
            services.AddScoped<IBookRepository, PostgresBookRepository>();
            services.AddScoped<IBookReadService, PostgresBookReadService>();
            
            var options = configuration.GetOptions<PostgresOptions>("Postgres");
            services.AddDbContext<ReadDbContext>(ctx => 
                ctx.UseNpgsql(options.ConnectionString));
            services.AddDbContext<WriteDbContext>(ctx => 
                ctx.UseNpgsql(options.ConnectionString));

            return services;
        }
    }
}