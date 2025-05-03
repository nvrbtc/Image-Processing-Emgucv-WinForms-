using APO_Tsarehradskiy.customUI;
using APO_Tsarehradskiy.customUI.Hough;
using APO_Tsarehradskiy.customUI.MorfologyMethods;
using APO_Tsarehradskiy.Services;
using APO_Tsarehradskiy.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;

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

            var culture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            ConfigureServices(services);

            MyServiceProvider.Initialize(services.BuildServiceProvider());
            var window = MyServiceProvider.GetRequiredService<MainUI>();
            
            Application.Run(window);
        }
        private static void ConfigureServices(IServiceCollection service)
        {
            service.AddSingleton<ImageManager>();
            service.AddSingleton<ITabManager,TabManager>();
            service.AddTransient<IInputHandler, InputHandler>();

            service.AddTransient<MainUI>();
            service.AddTransient<BlurWindow>();
            service.AddTransient<EdgeDetectionWindow>();
            service.AddTransient<UniversalFilterWindow>();
            service.AddTransient<HistogramWindow>();
            service.AddTransient<HoughWindow>();
            service.AddTransient<MedianFilterWindow>();
            service.AddTransient<PrewittWindow>();
            service.AddTransient<SharpWindow>();
            service.AddTransient<MorfologyWindow>();
            service.AddTransient<PosterizationWindow>();


            service.AddTransient<StrategyExecutor>();
        }
    }
}