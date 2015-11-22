using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBusTicketing.Models
{
    public class TicketingModel
    {
        public int id { get; set; }
        public CustomerModel customer_id { get; set; }
        public int no_of_seat { get; set; }
        public String ticket_no { get; set; }
        public CityModel station { get; set; }
        public DepartureModel departure_id { get; set; }
        

    }
}