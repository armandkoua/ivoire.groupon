using Contrats;
using LoggerService;
using Microsoft.AspNetCore.Builder;

namespace ivoire.groupon.Extensions
{
    public static class ServicesExtension
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(corsOptions => {
                corsOptions.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod());
            });
        }


        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {

            }
            );
        }

        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddSingleton<ILoggerManager, LoggerManager>();
    }
}
