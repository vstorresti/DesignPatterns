using System;

namespace Adapter
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            System.Console.WriteLine("Log padrão - " + message);
        }

        public void LogError(Exception exception)
        {
            System.Console.WriteLine("Log padrão - " + exception.Message);
        }
    }
}