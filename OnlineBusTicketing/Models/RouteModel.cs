using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBusTicketing.Models
{
    public class RouteModel
    {
        public int id { get; set; }
        public CityModel from_city_id { get; set; }
        public CityModel to_city_id { get; set; }
        public int price { get; set; }
    }
}