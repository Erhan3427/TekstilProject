using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Tekstile.BLL.Interfaces;
using Tekstile.BLL.MusteriService;
using Tekstile.BLL.Services;
using Tekstile.Context;
using Tekstile.Data;

namespace Tekstile
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
            var host = Host.CreateDefaultBuilder()
             .ConfigureServices(services =>
             {
                     services.AddDbContext<MyDbContext>();

                     // Servis katmaný
                     services.AddScoped<IMusteriService, MusteriService>();
                     services.AddScoped<IBoyaService, BoyaService>();
                     services.AddScoped<IStokService, BoyaStoguService>();
                     services.AddScoped<MakineService>();


                 // Formlar
                     services.AddTransient<FRMGiris>();
                     services.AddTransient<FRMBoya>();
                     services.AddTransient<FRMMusteri>();
                     services.AddTransient<FRMDesenYonetimi>();
                     services.AddTransient<FRMBoyaStogu>();
                     services.AddTransient<FRMMakineYonetimi>();
                 })
                 .Build();


            var girisFormu = host.Services.GetRequiredService<FRMGiris>();


            Application.Run(girisFormu);
        }
    }
}