using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProvisionSecond.Business.MapperProfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvisionSecond.MVCApplication.Extensions
{
    public static class AppServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddAutoMapper(options =>
            {
                options.AddProfile(typeof(CurrencyProfile));
            });

            return services;
        }
    }
}
