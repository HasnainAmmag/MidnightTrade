using Microsoft.Extensions.DependencyInjection;
using Repository; 
using Repository.Interfaces.Unit;
using Service.Implementations.Unit;
using Services.Implementation;
using Services.Interfaces;
using Services.Interfaces.Unit;

namespace Services
{
    public static class ServiceRegistration
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddRepository(); 
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<INftService, NftService>();
            services.AddScoped<IServiceUnit, ServiceUnit>();
        }
    }
}
