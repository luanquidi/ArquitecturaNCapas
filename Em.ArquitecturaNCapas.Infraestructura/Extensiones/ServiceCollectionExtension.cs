using Em.ArquitecturaNCapas.Aplicacion.Implementaciones;
using Em.ArquitecturaNCapas.Aplicacion.Interfaces;
using Em.ArquitecturaNCapas.Dominio.Core.Interfaces;
using Em.ArquitecturaNCapas.Dominio.Core.Servicios;
using Em.ArquitecturaNCapas.Infraestructura.Datos;
using Em.ArquitecturaNCapas.Infraestructura.Repositorios;
using Em.ArquitecturaNCapas.Transversal.Conexion;
using Em.ArquitecturaNCapas.Transversal.Logs;
using Microsoft.Extensions.DependencyInjection;

namespace Em.ArquitecturaNCapas.Infraestructura.Extensiones
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddSingleton<IConnectionFactory, ConexionFactory>();
            services.AddScoped<IAdmCargueDominio, AdmCargueDominio>();
            services.AddScoped<IAdmCargueDominio, AdmCargueRepository>();
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            services.AddScoped<IAdmCargueAplicacion, AdmCargueAplicacion>();
            return services;
        }
    }
}
