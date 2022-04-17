using Microsoft.Extensions.DependencyInjection;
using ProvisionSecond.Business.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvisionSecond.MVCApplication.Extensions
{
    public static class AppRepositories
    {
        public static IServiceCollection AddAppRepositories(this IServiceCollection services)
        {
            services.AddScoped<CurrencyRepo>();
            return services;
        }
    }
}
