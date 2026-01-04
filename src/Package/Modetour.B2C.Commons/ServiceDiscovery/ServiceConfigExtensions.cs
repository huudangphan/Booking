using Microsoft.Extensions.Configuration;
using Modetour.B2C.Commons.ServiceDiscovery;

namespace Modetour.B2C.Commons.ServiceDiscovery
{
    public static class ServiceConfigExtensions
    {
        public static ServiceConfig GetServiceConfig(this IConfiguration configuration)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }
            var serviceConfig = new ServiceConfig
            {
                Id = configuration["ServiceConfigId"],
                Name = configuration["ServiceConfigName"],
                Address = configuration["ServiceConfigAddress"],
                Port =Int32.Parse( configuration["ServiceConfigPort"]),
                DiscoveryAddress =new Uri( configuration["ServiceConfigDiscoveryAddress"]),
                HealthCheckEndPoint = configuration["ServiceConfigHealthCheckEndPoint"],
            };
                       
            return serviceConfig;
        }
    }
}