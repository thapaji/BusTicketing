using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBusTicketing.Models
{
    public class District
    {
        public int id { get; set; }
        public String name { get; set; }
        public Zone zoneId { get; set; }
    }
}