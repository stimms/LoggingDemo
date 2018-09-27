using Serilog;
using System;

namespace LoggingDemo.Serilog
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("logfile.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
            Log.Debug("Starting up");
            Log.Debug("Shutting down");
            Console.ReadLine();
        }
    }
}
