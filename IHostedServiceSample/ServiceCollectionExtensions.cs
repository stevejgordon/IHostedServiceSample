using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace IHostedServiceSample
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddHostedService<TService>(this IServiceCollection services)
            where TService : class, IHostedService
        {
            return services.AddSingleton<IHostedService, TService>();
        }
    }
}