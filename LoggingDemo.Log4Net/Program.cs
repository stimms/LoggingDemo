using log4net;
using log4net.Config;
using System;
using System.IO;
using System.Reflection;

namespace LoggingDemo.Log4Net
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
            log.Debug("Starting up");
            log.Debug("Shutting down");
            Console.ReadLine();
        }
    }
}
