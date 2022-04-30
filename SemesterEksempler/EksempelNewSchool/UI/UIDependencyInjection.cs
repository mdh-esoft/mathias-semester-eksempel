using Microsoft.Extensions.DependencyInjection;

namespace EksempelNewSchool.UI
{
    public class UIDependencyInjection
    {
        public static void Inject(IServiceCollection services)
        {
            // INSPIRATION: https://stackoverflow.com/a/70476716
            services.AddTransient<Form1>();

            // Bemærk, når man så vil starte en ny dialog op, skal man benytte (husk at udskifte "Form2" med den dialog du ønsker at vise):
            // Program.ServiceProvider.GetRequiredService<Form2>()
        }
    }
}
