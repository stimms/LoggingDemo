using NLog;
using System;

namespace LoggingDemo.Nlog
{
    class Program
    {
        static void Main(string[] args)
        {
            LogManager.LoadConfiguration("nlog.config");
            var log = LogManager.GetCurrentClassLogger();
            log.Debug("Starting up");
            log.Debug("Shutting down");
            Console.ReadLine();
        }
    }
}
