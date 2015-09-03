using System;

namespace AdvWrks.DataModel
{
    public class ShiftData
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
