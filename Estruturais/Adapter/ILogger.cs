using System;

namespace Adapter
{
    public interface ILogger
    {
         void Log(string message);
         void LogError(Exception exception);
    }
}