using LearningApp.Data;
using LearningApp.Data.Repositories.Implementations;
using LearningApp.Data.Repositories.Interfaces;
using LearningApp.Services.Implementations;
using LearningApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LearningApp.Configurations
{
    public static class ConfigureDI
    {
        public static void AddRepositoryDI(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
        }

        public static void AddServiceDI(this IServiceCollection services)
        {
            services.AddScoped<IGetCompleteUserService, GetCompleteUserService>();
        }

        public static void AddContextDI(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddDbContext<Context>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Context")));
        }
    }
}
