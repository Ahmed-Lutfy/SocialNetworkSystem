using Microsoft.Extensions.DependencyInjection;
using Social.Application.Service.Interface;
using Social.Application.Service.ServiceClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Social.Application.Configration
{
   public static class DependancyInjection
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddScoped<IPostService, PostService>();

            return services;
        }

        

    }
}
