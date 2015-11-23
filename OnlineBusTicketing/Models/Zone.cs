using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBusTicketing.Models
{
    public class Zone
    {
        public int ZoneId { get; set; }
        public String Name { get; set; }
        public virtual ICollection<District> Districts { get; set; }
    }
}