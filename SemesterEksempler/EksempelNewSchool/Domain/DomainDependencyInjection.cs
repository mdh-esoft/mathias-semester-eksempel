using Microsoft.Extensions.DependencyInjection;

namespace EksempelNewSchool.Domain
{
    public class DomainDependencyInjection
    {
        public static void Inject(IServiceCollection services)
        {
            // INSPIRATION: https://stackoverflow.com/a/70476716
            services.AddSingleton<IMedlemsDomain, MedlemsDomain>();
        }
    }
}
