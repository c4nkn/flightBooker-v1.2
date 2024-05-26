using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBooker.Models
{
    public class Aircraft
    {
        public int Id { get; set; }
        public string AircraftType { get; set; }
        public string TypeCode { get; set; }
        public string Manufacturer { get; set; }
        public int Capacity { get; set; }
    }
}
