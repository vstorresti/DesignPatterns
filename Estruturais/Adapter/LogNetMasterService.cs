using System;

namespace Adapter
{
    public class LogNetMasterService : ILogNetMaster
    {
        public void LogInfo(string message)
        {
            System.Console.WriteLine("Log Customizado - " + message);
        }

        public void LogException(Exception exception)
        {
            System.Console.WriteLine("Log Customizado - " + exception.Message);
        }
    }
}