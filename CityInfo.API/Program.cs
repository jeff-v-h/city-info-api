using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;

namespace CityInfo.API
{
    public class Program
    {        
        // Main entry point for the application
        public static void Main(string[] args)
        {
            // NLog: setup the logger first to catch all errors
            var logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();

            try
            {
                logger.Debug("init main");
                // create the web host builder
                CreateWebHostBuilder(args)
                    // build the web host
                    .Build()
                    // and run the web host, i.e. your web application
                    .Run();
            }
            catch (Exception ex)
            {
                //NLog: catch setup errors
                logger.Error(ex, "Stopped program because of exception");
                throw;
            }
            finally
            {
                // Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
                NLog.LogManager.Shutdown();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            // create a default web host builder, with the default settings and configuration
            WebHost.CreateDefaultBuilder(args)
                // configure it to use your 'Startup' class
                .UseStartup<Startup>();
    }
}
