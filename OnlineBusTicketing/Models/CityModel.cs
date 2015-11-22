using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBusTicketing.Models
{
    public class CityModel
    {
        public int id { get; set; }
        public String city { get; set; }
        public DistrictModel district_id { get; set; }

    }
}