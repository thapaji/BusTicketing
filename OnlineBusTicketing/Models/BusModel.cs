using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBusTicketing.Models
{
    public class BusModel
    {
        public int id { get; set; }
        public String no_plate { get; set; }
        public CompanyModel company_id { get; set; }
        public int no_of_seat_A { get; set; }
        public int no_of_seat_B { get; set; }

    }
}