using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjWebServicesConsole
{
    class Institution
    {
        public string Department { get; set; }
        public string House { get; set; }

        public Institution(string department, string house)
        {
            this.Department = department;
            this.House = house;
        }
    }
}
