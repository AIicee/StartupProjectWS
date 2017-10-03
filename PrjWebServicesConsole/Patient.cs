using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjWebServicesConsole
{
    class Patient
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public Patient(string name, string location)
        {
            this.Name = name;
            this.Location = location;
        }
    }
}
