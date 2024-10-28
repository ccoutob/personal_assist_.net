using Ecommerce.Cliente.Application.Services;
using Ecommerce.Cliente.Data.Factory;
using Ecommerce.Cliente.Data.Repositories;
using Ecommerce.Cliente.Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Cliente.IoC
{
    public class Bootstrap
    {
        public static void Start(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(x => {
                return DataFactory.CreateInstance(configuration.GetConnectionString("MongoDb") ?? "");
            });

            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<IClienteApplicationService, ClienteApplicationService>();

        }
    }
}
