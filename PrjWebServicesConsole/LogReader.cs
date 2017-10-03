using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjWebServicesConsole
{
    class LogReader
    {
        public List<Incident> incidents { get; set; }

        public LogReader()
        {
            incidents = new List<Incident>();
        }

        public void ReadLog()
        {
            //Reads log
        }

        public void UpdateList()
        {
            //Updates the "incidents" list, this method is called every 3-5 seconds
        }

        public List<Incident> FindIncidentsByName(Patient patient)
        {
            List<Incident> ListByName = new List<Incident>();
            ListByName = incidents.FindAll(x => x.Patient.Name == patient.Name);

            return ListByName;
        }
    }
}
