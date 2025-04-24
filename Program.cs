using APO_Tsarehradskiy.Services;
using APO_Tsarehradskiy.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace APO_Tsarehradskiy
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            ConfigureServices(services);

            var provider = services.BuildServiceProvider();

            var window = provider.GetRequiredService<MainForm>();
            
            Application.Run(window);
        }
        private static void ConfigureServices(IServiceCollection service)
        {

            service.AddSingleton<ImageManager>();
            service.AddSingleton<ITabManager,TabManager>();

            service.AddTransient<MainForm>();

        }
    }
}