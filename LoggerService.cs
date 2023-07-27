

using Serilog;
using Serilog.Settings.Configuration;
using Serilog.Core;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace LoggerServiceLibrary
{
    public static class MyLogger
    {

        private static ILogger logger;
        static MyLogger()
        {

            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", true)
                .Build();

            logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();
        }
        /// <summary>
        /// Prints <paramref name="message"/> to defined output sink 
        /// in appsettings.json at Verbose level (level 1)
        /// </summary>
        /// <param name="message">The message to be logged</param>
        public static void logVerbose(string message)
        {
            logger.Verbose(message);
        }
        /// <summary>
        /// Prints <paramref name="message"/> to defined output sink 
        /// in appsettings.json at Debug level (level 2)
        /// </summary>
        /// <param name="message">The message to be logged</param>
        public static void logDebug(string message)
        {
            logger.Debug(message);
        }
        /// <summary>
        /// Prints <paramref name="message"/> to defined output sink 
        /// in appsettings.json at Information level (level 3)
        /// </summary>
        /// <param name="message">The message to be logged</param>
        public static void logInfo(string message)
        {
            logger.Information(message);
        }

        /// <summary>
        /// Prints <paramref name="message"/> to defined output sink 
        /// in appsettings.json at Warning level (level 4)
        /// </summary>
        /// <param name="message">The message to be logged</param>
        public static void logWarning(string message)
        {
            logger.Warning(message);
        }

        /// <summary>
        /// Prints <paramref name="message"/> to defined output sink 
        /// in appsettings.json at Error level (level 5)
        /// </summary>
        /// <param name="message">The message to be logged</param>
        public static void logError(string message)
        {
            logger.Error(message);
        }
        /// <summary>
        /// Prints <paramref name="message"/> to defined output sink 
        /// in appsettings.json at Fatal level (level 6)
        /// </summary>
        /// <param name="message">The message to be logged</param>
        public static void logFatal(string message)
        {
            logger.Fatal(message);
        }

    }

   
}