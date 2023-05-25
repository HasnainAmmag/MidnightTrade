using Microsoft.Extensions.DependencyInjection;
using Repository.Implementations.Unit;
using Repository.Interfaces.Unit;
using Repository.Interfaces; // Add the namespace for IAccountRepository
using Repository.Implementations;

namespace Repository
{
    public static class RepositoryRegistration
    {
        public static void AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<INftRepository, NftRepository>();
            services.AddScoped<IRepositoryUnit, RepositoryUnit>();
        }
    }
}
