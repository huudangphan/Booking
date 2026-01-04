using Consul;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Modetour.B2C.Commons.ServiceDiscovery
{
    public static class ServiceDiscoveryExtensions
    {
        public static void AddConsul(this IServiceCollection services, ServiceConfig serviceConfig)
        {
            if (serviceConfig == null)
            {
                throw new ArgumentNullException(nameof(serviceConfig));
            }
            Console.WriteLine("serviceConfig.DiscoveryAddress" + serviceConfig.Address);
            var consulClient = new ConsulClient(config =>
            {
                config.Address = serviceConfig.DiscoveryAddress;
            });

            services.AddSingleton(serviceConfig);
            services.AddSingleton<IConsulClient, ConsulClient>(_ => consulClient);
            services.AddSingleton<IHostedService, ServiceDiscoveryHostedService>();
        }
    }
}
