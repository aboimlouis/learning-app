using LearningApp.Domain.Profiles.Character;
using System.Reflection;

namespace LearningApp.Configurations
{
    public static class ConfigureAutoMapper
    {
        public static void ConfigureAutoMapperProfiles(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetAssembly(typeof(CharacterProfile)));
        }
    }
}
