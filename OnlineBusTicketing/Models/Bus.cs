using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBusTicketing.Models
{
    public class Bus
    {
        public int BusId { get; set; }
        public String NoPlate { get; set; }
        public int NoOfSeatsA { get; set; }
        public int NoOfSeatsB { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public virtual ICollection<Departure> Departures { get; set; }

    }
}