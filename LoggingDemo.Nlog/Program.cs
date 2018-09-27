using NLog;
using System;

namespace LoggingDemo.Nlog
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigureFromCode();
            var log = LogManager.GetCurrentClassLogger();
            log.Debug("Starting up");
            log.Debug("Shutting down");
            Console.ReadLine();
        }

        private static void ConfigureFromFile()
        {
            LogManager.LoadConfiguration("nlog.config");
        }

        private static void ConfigureFromCode()
        {
            var config = new NLog.Config.LoggingConfiguration();

            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "logfile.txt" };
            var logconsole = new NLog.Targets.ConsoleTarget("logconsole");

            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logconsole);
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);

            NLog.LogManager.Configuration = config;
        }
    }
}
