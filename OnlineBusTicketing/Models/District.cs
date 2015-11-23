using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBusTicketing.Models
{
    public class District
    {
        public int DistrictId { get; set; }
        public String Name { get; set; }
        public int ZoneId { get; set; }
        public Zone Zone { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}