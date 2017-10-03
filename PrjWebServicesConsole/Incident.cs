using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjWebServicesConsole
{
    class Incident
    {
        public Patient Patient { get; set; }
        public Sensor Sensor { get; set; }
        public Alarm Alarm { get; set; }
        public Institution Institution { get; set; }

        public Incident(Patient patient, Sensor sensor, Alarm alarm, Institution institution)
        {
            this.Patient = patient;
            this.Sensor = sensor;
            this.Alarm = alarm;
            this.Institution = institution;
        }
    }
}
