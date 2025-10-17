using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Social.Domain.Interface;
using Social.Infrastructure.Presistance.Data;
using Social.Infrastructure.Presistance.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Infrastructure.Configration
{
   public static class DependancyInjection
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services ,IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDBContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SocialNetworkSystem"));
            });

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IPostRepository, PostRepository>();

            return services;
        }

        public static WebApplication AddInfrastructureWeb(this WebApplication app)
        {

            return app;
        }
    }
}
