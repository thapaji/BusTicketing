using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBusTicketing.Models
{
    public class Departure
    {
        public int DepartureId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public int BusId { get; set; }
        public int RouteId { get; set; }
        public Bus Bus { get; set; }
        public Route Route { get; set; }
    }
}