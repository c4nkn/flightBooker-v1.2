using FlightBooker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBooker.Data
{
    public class DbLoader
    {
        private static Random random = new Random();
        private static List<string> Airlines = new List<string> { "TK", "VF", "PC", "XQ" };
        private static List<string> SeatLetters = new List<string> { "A", "B", "C", "D", "E", "F" };

        public static void InitDatabase(AppDbContext context)
        {
            var defaultAircrafts = new List<Aircraft>()
            {
                new Aircraft
                {
                    AircraftType = "Boeing 737-800",
                    TypeCode = "B738",
                    Manufacturer = "Boeing",
                    Capacity = 150
                },
                new Aircraft
                {
                    AircraftType = "Airbus A320",
                    TypeCode = "A320",
                    Manufacturer = "Airbus",
                    Capacity = 150
                },
            };

            context.Aircrafts.AddRange(defaultAircrafts);
            context.SaveChanges();

            var defaultAirports = new List<Airport>()
            {
                new Airport
                {
                    Name = "Sabiha Gokcen Airport (SAW)",
                    ICAOCode = "LTFJ",
                    City = "Istanbul",
                    Country = "Turkey"
                },
                new Airport
                {
                    Name = "Ordu-Giresun Airport (OGU)",
                    ICAOCode = "LTCB",
                    City = "Giresun",
                    Country = "Turkey"
                },
                new Airport
                {
                    Name = "Adnan Menderes Airport (ADB)",
                    ICAOCode = "LTBJ",
                    City = "Izmir",
                    Country = "Turkey"
                },
                new Airport
                {
                    Name = "Istanbul Airport (IGA)",
                    ICAOCode = "LTFM",
                    City = "Istanbul",
                    Country = "Turkey"
                }
            };

            context.Airports.AddRange(defaultAirports);
            context.SaveChanges();
            GenerateFlights(context, defaultAirports);
        }

        private static void GenerateFlights(AppDbContext context, List<Airport> airports)
        {
            var flights = new List<Flight>();
            var allAircrafts = context.Aircrafts.ToList();

            foreach (var departure in airports)
            {
                foreach (var destination in airports.Where(a => a.Id != departure.Id))
                {
                    for (int i = 0; i < 5; i++)
                    {
                        var airline = Airlines[random.Next(Airlines.Count)];
                        var flightNumber = $"{airline}{random.Next(1000, 9999)}";
                        var departureTime = RandomTime();
                        var departureDateTime = DateTime.Today.AddDays(random.Next(1, 30)).AddHours(departureTime.Hour).AddMinutes(departureTime.Minute); // Combine date and time
                        var flightDuration = random.Next(1, 5) * 60;
                        var arrivalTime = departureDateTime.AddMinutes(flightDuration);

                        var takenSeats = RandomSeats();
                        var randomAircraft = allAircrafts[random.Next(allAircrafts.Count)];

                        flights.Add(new Flight
                        {
                            FlightNumber = flightNumber,
                            Date = departureDateTime,
                            FlightTime = $"{flightDuration / 60}h {flightDuration % 60}m",
                            DepartureTime = departureTime.ToString("HH:mm"),
                            ArrivalTime = arrivalTime.ToString("HH:mm"),
                            Airline = GetAirline(airline),
                            Aircraft = randomAircraft,
                            TakenSeats = string.Join(", ", takenSeats),
                            DepartureId = departure.Id,
                            Departure = departure,
                            DestinationId = destination.Id,
                            Destination = destination,
                            TotalPrice = random.Next(100, 1000)
                        });
                    }
                }
            }

            context.Flights.AddRange(flights);
            context.SaveChanges();
        }

        private static DateTime RandomTime()
        {
            var hour = random.Next(0, 24);
            var minute = random.Next(0, 6) * 10;
            return DateTime.Today.AddHours(hour).AddMinutes(minute);
        }

        private static List<string> RandomSeats()
        {
            var seats = new List<string>();
            var numberOfSeats = random.Next(1, 10);
            for (int i = 0; i < numberOfSeats; i++)
            {
                var seatLetter = SeatLetters[random.Next(SeatLetters.Count)];
                var seatNumber = random.Next(1, 31);
                seats.Add($"{seatLetter}{seatNumber}");
            }
            return seats;
        }

        private static string GetAirline(string code)
        {
            switch (code)
            {
                case "TK":
                    return "Turkish Airlines";
                case "VF":
                    return "AJet";
                case "PC":
                    return "Pegasus Airlines";
                case "XQ":
                    return "Sunexpress";
                default:
                    return "N/A";
            }
        }
    }
}
