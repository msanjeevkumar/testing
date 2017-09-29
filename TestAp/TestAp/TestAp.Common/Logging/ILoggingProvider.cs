﻿using System.Threading.Tasks;

namespace TestAp.Common.Logging
{
    public interface ILoggingProvider
    {
        void Log(
            string message,
            LogLevel level,
            object data,
            string[] tags,
            string callerFullTypeName,
            string callerMemberName,
            long? timeInMilliseconds = null);

        Task ClearLogsAsync();
    }
}
