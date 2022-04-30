
using EksempelNewSchool.DAL;
using EksempelNewSchool.Domain;
using EksempelNewSchool.UI;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EksempelNewSchool
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<Form1>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {

                    // INSPIRATION: https://stackoverflow.com/a/70476716

                    // Inject Data Access Layer
                    DALDependencyInjection.Inject(services);

                    // Inject Domain layer
                    DomainDependencyInjection.Inject(services);

                    // Inject UI layer
                    UIDependencyInjection.Inject(services);
                });
        }
    }
}