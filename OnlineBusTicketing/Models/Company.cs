using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBusTicketing.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public String Name { get; set; }
        public int DistrictId { get; set; }
        public District District { get; set; }
        public virtual ICollection<Bus> Buses { get; set; }
    }
}