using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjWebServicesConsole
{
    class Alarm
    {
        public string Type { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeRegistered { get; set; }

        public Alarm(string time, DateTime start, DateTime registered)
        {
            this.Type = Type;
            this.TimeStart = start;
            this.TimeRegistered = registered;
        }
    }
}
