using Microsoft.Extensions.DependencyInjection;
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

            return services;
        }

        

    }
}
