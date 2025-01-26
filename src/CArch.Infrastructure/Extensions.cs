using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CArch.Application.Services;
using CArch.Infrastructure.EF;
using CArch.Infrastructure.Logging;
using CArch.Shared.Abstractions.Commands;
using CArch.Shared.Queries;

namespace CArch.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddPostgres(configuration);
            services.AddQueries();

            services.TryDecorate(typeof(ICommandHandler<>), typeof(LoggingCommandHandlerDecorator<>));
            
            return services;
        }
    }
}