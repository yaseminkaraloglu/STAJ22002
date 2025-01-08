using Bimser.CSP.Workflow.Runtime.Common.Extensions;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;
using System.IO;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace FazlaMesaiSureciYK
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            ProjectExtension.LoadEnvironments();
            CreateWebHostBuilder(new string[] { }).Run();
        }

        public static IWebHost CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    config.AddJsonFile("appsettings.json",
                        optional: true,
                        reloadOnChange: false);
                })
                .UseKestrel()
                .UseStartup<Startup>()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseUrls(Environment.GetEnvironmentVariable("Urls") ?? "http://*:80")
                .Build();

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                // Log exception
                StringBuilder sb = new StringBuilder();
                Exception ex = (Exception)e.ExceptionObject;
                sb.AppendLine($"Unhandled exception: {ex.Message}");
                sb.AppendLine($"Exception source: {ex.Source}");
                sb.AppendLine($"State is terminating: {e.IsTerminating}");
                sb.AppendLine($"Exception: {ex}");

                File.WriteAllText($"{Guid.NewGuid()}.log", sb.ToString());
            }
            catch
            {
                // do nothing to silently swallow error
            }
        }
    }
}