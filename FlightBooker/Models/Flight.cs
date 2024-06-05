using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBooker.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public string FlightNumber { get; set; }
        public DateTime Date { get; set; }
        public string FlightTime { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public string Airline { get; set; }
        public Aircraft Aircraft { get; set; } = new Aircraft();
        public string TakenSeats { get; set; }
        public int DepartureId { get; set; }
        public Airport Departure { get; set; } = new Airport();
        public int DestinationId { get; set; }
        public Airport Destination { get; set; } = new Airport();
        public decimal TotalPrice { get; set; }
    }
}
