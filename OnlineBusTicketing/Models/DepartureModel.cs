using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBusTicketing.Models
{
    public class DepartureModel
    {
        public int id { get; set; }
        public BusModel bus_id { get; set; }
        public RouteModel route_id { get; set; }
        public DateTime date { get; set; }
        public TimeSpan departure_time { get; set; }
    }
}