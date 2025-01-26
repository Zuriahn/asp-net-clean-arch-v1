using Microsoft.Extensions.DependencyInjection;
using CArch.Domain.Factories;
using CArch.Shared;
using CArch.Shared.Commands;

namespace CArch.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddCommands();
            services.AddSingleton<IBookFactory, BookFactory>();
            services.AddSingleton<IAuthorFactory, AuthorFactory>();
            
            return services;
        }
    }
}