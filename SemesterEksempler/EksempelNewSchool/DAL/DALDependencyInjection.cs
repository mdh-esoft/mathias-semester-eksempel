using Microsoft.Extensions.DependencyInjection;

namespace EksempelNewSchool.DAL
{
    public class DALDependencyInjection
    {
        public static void Inject(IServiceCollection services)
        {
            // INSPIRATION: https://stackoverflow.com/a/70476716

            var settings = new DALSettings("dette-skal-være-en-connectionString");

            services.AddSingleton<DALSettings>(settings);
            services.AddSingleton<IMedlemsDAL, MedlemsDAL>();
        }
    }
}
