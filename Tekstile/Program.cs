using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Windows.Forms;
using Tekstile.BLL.Interfaces;
using Tekstile.BLL.MusteriService;
using Tekstile.BLL.Services;
using Tekstile.BLL.Services.CRUD;
using Tekstile.BLL.Services.Interfaces;
using Tekstile.Context;
using Tekstile.DAL.Repositories.Implementations;
using Tekstile.DAL.Repositories.Interfaces;
using Tekstile.DAL.Repositories.Services;
using Tekstile.Data;
using Tekstile.Helpers;
using Tekstile.UI;

namespace Tekstile
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();

        

            // Formu DI ile alýp çalýþtýrýyoruz
            var form = host.Services.GetRequiredService<AnaGiris>();
            Application.Run(form);
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    // DbContext kaydý
                    services.AddDbContext<MyDbContext>();

                    services.AddScoped<IMusteriRepo, MusteriRepositories>();
                    services.AddScoped<IDesenRepo, DesenRepositories>();
                    services.AddScoped<IBoyaRepo, BoyaRepositories>();
                    services.AddScoped<IGiderRepo, GiderRepositories>();
                    services.AddScoped<IKumasRepo, KumasRepositories>();
                    services.AddScoped<IMakineRepo, MakineRepositories>();
                    services.AddScoped<IRaporRepo, RaporRepositories>();
                    services.AddScoped<ISiparisYonetimiRepo, SiparisYonetimiRepositories>();
                    services.AddScoped<IStokRepo, BoyaStoguRepositories>();
                    services.AddScoped<IDesenBoyaRepo, DesenBoyaRepositories>();
                    services.AddScoped<ICalisanRepo, CalisanRepositories>();






                    // Servis kayýtlarý

                    services.AddScoped<ICalisanService, CalisanService>();
                    services.AddScoped<IDesenBoyaService, DesenBoyaService>();
                    services.AddScoped<IMusteriService, MusteriService>();
                    services.AddScoped<IDesenService, DesenService>();
                    services.AddScoped<IBoyaService, BoyaService>();
                    services.AddScoped<IGiderService, GiderService>();
                    services.AddScoped<IKumasService, KumasService>();
                    services.AddScoped<IMakineService, MakineService>();
                    services.AddScoped<IRaporService, RaporService>();
                    services.AddScoped<ISiparisYonetimiService, SiparisYonetimiService>();
                    services.AddScoped<IStokService, StokService>();

                    services.AddScoped<AnaGiris>();
                    services.AddScoped<FRMMusteri>();
                    services.AddScoped<FRMBoya>();
                    services.AddScoped<FRMDesenYonetimi>();
                    services.AddScoped<FRMMakineYonetimi>();
                    services.AddScoped<FRMSiparisYonetimi>();
                    services.AddScoped<FRMGelir>();
                    services.AddScoped<FRMGider>();
                    services.AddScoped<FRMRaporlama>();
                    services.AddScoped<FRMMuhasebeGiris>();
                    services.AddScoped<FRMGiris>();
                    services.AddScoped<FRMBoyaStogu>();
                    services.AddScoped<FRMCalisan>();
                    services.AddScoped<FRMKasaDurumu>();






                });
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Exception ex = e.Exception;
            LogKayit.LogEkle("SYSTEM", "ThreadException", ex.ToString());
            MessageBox.Show("Bilinmedik bir hata oluþtu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = e.ExceptionObject as Exception;
            if (ex == null) return;
            LogKayit.LogEkle("SYSTEM", "DomainUnhandledException", ex.ToString());
            MessageBox.Show("Bilinmedik ve ciddi bir hata oluþtu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
