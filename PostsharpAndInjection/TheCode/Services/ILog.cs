using System;

namespace PostsharpAndInjection.TheCode.Services
{
    public interface ILog
    {
        void LogError(Exception ex);

        void LogDebug(string message);
    }
}
