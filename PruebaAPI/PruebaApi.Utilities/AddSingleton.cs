using Microsoft.Extensions.DependencyInjection;
using PruebaApi.Negocio.Interface;
using PruebaApi.Negocio.Negocio;

namespace PruebaApi.Utilities
{
    public static class AddSingleton
    {
        public static IServiceCollection CreateSingleton(this IServiceCollection services)
        {
            services.AddSingleton<IPracticaNegocio,PracticaNegocio>();
            return services;
        }
    }
}
