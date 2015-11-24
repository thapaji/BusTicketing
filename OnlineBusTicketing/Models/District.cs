using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBusTicketing.Models
{
    [Table("tbl_district")]
    public class District
    {
        [Column("district_id")]
        public int DistrictId { get; set; }

        [Column("district_name")]
        public String Name { get; set; }

        [Column("zone_id")]
        public int ZoneId { get; set; }

        public Zone Zone { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}