using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBusTicketing.Models
{
    public class TicketingDetail
    {
        public int id { get; set; }
        public TicketingModel ticket_id { get; set; }
        public CustomerModel person_name { get; set; }
        public CityModel from_station_id { get; set; }
        public CityModel to_station_id { get; set; }
        public RouteModel price { get; set; }
    }
}