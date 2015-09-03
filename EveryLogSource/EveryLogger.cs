using EveryLogSource.Events;
using EveryLogSource.LogTypes;
using System;
using System.Collections.Generic;

namespace EveryLogSource
{
    public class EveryLogger : IEveryLogger
    {
        private readonly Dictionary<int, Action<string>> _LogDict = 
            new Dictionary<int, Action<string>>();

        public EveryLogger()
        {
            var logSourceWrapper = new EveryLoggerSourceWrapper();
            logSourceWrapper.RegisterLogger(_LogDict);
        }
        public void Log(int log, string LogMessages)
        {
            if (_LogDict.ContainsKey(log))
            {
                _LogDict[log].Invoke(LogMessages);
                return;
            }
            _LogDict[GlobalType.GlobalWarning].Invoke(LogMessages);
        }
    }
}