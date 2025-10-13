namespace Social.PL.Razor.Configration
{
    public static class DependancyInjection
    {
        
            public static IServiceCollection AddRazorService(this IServiceCollection services)
            {

                return services;
            }

            public static WebApplication AddRazorWeb(this WebApplication app)
            {

                return app;
            }
        }
    }

