using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Logging;
using Tekstile.BLL.Interfaces;
using Tekstile.BLL.MusteriService;
using Tekstile.BLL.Services;
using Tekstile.Context;
using Tekstile.Data;
using Tekstile.UI;
using Tekstile.Helpers;

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

            // Instantiate the FRMGiris form before passing it to Application.Run  
            Application.Run(new AnaGiris());
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