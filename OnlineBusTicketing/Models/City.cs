using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBusTicketing.Models
{
    public class City
    {
        public int CityId { get; set; }
        public String Name { get; set; }
        public int DistrictId { get; set; }
        public District District { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Route> FromCity { get; set; }
        public virtual ICollection<Route> ToCity { get; set; }
    }
}