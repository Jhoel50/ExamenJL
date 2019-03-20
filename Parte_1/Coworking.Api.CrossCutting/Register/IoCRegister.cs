using Coworking.Api.Aplication.Contracts.Services;
using Coworking.Api.Aplication.Services;
using Coworking.Api.DataAccess.Contracts.Repositories;
using Coworking.Api.DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.CrossCutting.Register
{
    public  static class IoCRegister
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            AddRegisterServices(services);
            AddRegisterRepositories(services);

            return services;

        }
        private static IServiceCollection AddRegisterServices(IServiceCollection services)
        {
            services.AddTransient<IBancoService, BancoService>();
            services.AddTransient<IOrdenPagoService, OrdenPagoService>();
            services.AddTransient<ISucursalService, SucursalService>();
            return services;
        }
        private static  IServiceCollection AddRegisterRepositories(IServiceCollection services)
        {
            services.AddTransient<IBancoRepository, BancoRepository>();
            services.AddTransient<IOrdenPagoRepository, OrdenPagoRepository>();
            services.AddTransient<ISucursalRepository, SucursalRepository>();
            services.AddTransient<IOrdenPagoRepository, OrdenPagoRepository>();

            return services;
        }
    }
}
