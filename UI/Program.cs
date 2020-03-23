using Domain.Interface;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Service;
using System;
using System.Windows.Forms;

namespace UI
{
    static class Program
    {
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<FormMain>();
            services.AddSingleton<IDigitalMicroWaveRepository, DigitalMicroWaveRepository>();
            services.AddSingleton<IDigitalMicroWaveService, DigitalMicroWaveService>();
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var service = services.BuildServiceProvider().GetRequiredService<IDigitalMicroWaveService>();

                Application.Run(new FormMain(service));
            }
        }
    }
}