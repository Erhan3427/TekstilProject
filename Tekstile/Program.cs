using Microsoft.Extensions.DependencyInjection;
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

            // Instantiate the FRMGiris form before passing it to Application.Run  
            Application.Run(new FRMGiris());
        }
    }
}