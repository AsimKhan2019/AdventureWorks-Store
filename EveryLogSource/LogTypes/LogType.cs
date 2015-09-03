using System.Diagnostics.Tracing;

namespace EveryLogSource.LogTypes
{
    public class GlobalType
    {
        public const int GlobalInformational = 1;
        public const int GlobalCritical = 2;
        public const int GlobalError = 3;
        public const int GlobalLogAlways = 4;
        public const int GlobalVerbose = 5;
        public const int GlobalWarning = 6;
    }
}
