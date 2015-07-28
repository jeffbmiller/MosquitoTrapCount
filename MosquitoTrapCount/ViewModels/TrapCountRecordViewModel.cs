using System;
using Xamarin.Forms;

namespace MosquitoTrapCount
{
    public class TrapCountRecordViewModel
    {
        private readonly TrapCountRecord model;

        public TrapCountRecordViewModel(TrapCountRecord model)
        {
            this.model = model;
        }

        public string Month {get { return model.SamplingDate.ToString("MMM").ToUpper(); }}
        public int Day {get { return model.SamplingDate.Day; }}

        public int Trap1 {get {return model.Trap1;}}
        public string Trap1CountDisplay {get { return string.Format("Trap 1 - {0}",Trap1); }}
        public int Trap2 {get {return model.Trap2;}}
        public string Trap2CountDisplay {get { return string.Format("Trap 2 - {0}",Trap2); }}
        public int Trap3 {get {return model.Trap3;}}
        public string Trap3CountDisplay {get { return string.Format("Trap 3 - {0}",Trap3); }}
        public int Trap4 {get {return model.Trap4;}}
        public string Trap4CountDisplay {get { return string.Format("Trap 4 - {0}",Trap4); }}
        public int Trap5 {get {return model.Trap5;}}
        public string Trap5CountDisplay {get { return string.Format("Trap 5 - {0}",Trap5); }}
        public int Avg {get {return model.DailyAvgCount; }}
        public Color MonthColor 
        { 
            get { 
                switch (Month)
                {
                    case "MAY":
                        return Color.Purple;
                        break;
                    case "JUN":
                        return Color.Lime;
                        break;
                    case "JUL":
                        return Color.Maroon;
                        break;
                    case "AUG":
                        return Color.Red;
                        break;
                    case "SEP":
                        return Color.Blue;
                        break;
                    default:
                        return Color.Black;
                        break;
                }

            }
        }
    }
}

