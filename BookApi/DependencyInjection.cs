using Application;

using DataAccess;
using Mapster;
using MapsterMapper;
using System.Reflection;
using Application.Configuration;

namespace BookApi
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<SecretCode>(configuration.GetSection("SecretCode"));
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddDataAccess(configuration);
            services.AddApplication(configuration);
            services.AddMapsterConfiguration();
            return services;
        }

        private static IServiceCollection AddMapsterConfiguration(this IServiceCollection services)
        {
            var config = TypeAdapterConfig.GlobalSettings;
            services.AddSingleton(config);
            services.AddScoped<IMapper, ServiceMapper>();
            TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());
            return services;
        }
    }
    
}
