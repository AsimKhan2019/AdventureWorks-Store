using EveryLogSource.LogTypes;
using System;
using System.Collections.Generic;

namespace EveryLogSource.Events
{
    public class EveryLoggerSourceWrapper
    {
        public void RegisterLogger(Dictionary<int, Action<string>> exectueLogDict)
        {
            exectueLogDict.Add(GlobalType.GlobalCritical, Critical);
            exectueLogDict.Add(GlobalType.GlobalError, Error);
            exectueLogDict.Add(GlobalType.GlobalInformational, Informational);
            exectueLogDict.Add(GlobalType.GlobalLogAlways, LogAlways);
            exectueLogDict.Add(GlobalType.GlobalVerbose, Verbose);
            exectueLogDict.Add(GlobalType.GlobalWarning, Warning);
        }

        public void Critical(string message)
        {
            EveryLoggerSource.Log.Critical(message);
        }

        public void Error(string message)
        {
            EveryLoggerSource.Log.Error(message);
        }

        public void Informational(string message)
        {
            EveryLoggerSource.Log.Informational(message);
        }

        public void LogAlways(string message)
        {
            EveryLoggerSource.Log.LogAlways(message);
        }

        public void Verbose(string message)
        {
            EveryLoggerSource.Log.Verbose(message);
        }

        public void Warning(string message)
        {
            EveryLoggerSource.Log.Warning(message);
        }
    }
}
