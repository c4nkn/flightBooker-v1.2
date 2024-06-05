using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBooker.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string PassengerName { get; set; }
        public string PassengerSurname { get; set; }
        public int SelectedFlightId { get; set; }
        public Flight SelectedFlight { get; set; }
        public string SelectedSeat { get; set; }
        public string PNRCode { get; set; }
    }
}
