using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBusTicketing.Models
{
    public class DistrictModel
    {
        public int id { get; set; }
        public String name { get; set; }
        public Zone zone_id { get; set; }

    }
}