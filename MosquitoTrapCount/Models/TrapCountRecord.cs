using System;

namespace MosquitoTrapCount
{
    public class TrapCountRecord
    {
        public DateTime SamplingDate { get; set; }
        public string SamplingDateDisplay {get { return SamplingDate.ToString("d"); }}
        public int Trap1 { get; set; }
        public int Trap2 { get; set; }
        public int Trap3 { get; set; }
        public int Trap4 { get; set; }
        public int Trap5 { get; set; }
        public int DailyAvgCount { get; set; }
        public string AFAValue { get; set; }
    }
}

