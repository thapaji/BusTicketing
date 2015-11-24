using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBusTicketing.Models
{
    [Table("tbl_city")]
    public class City
    {
        [Column("city_id")]
        public int CityId { get; set; }

        [Column("city_name")]
        public String Name { get; set; }

        [Column("district_id")]
        public int DistrictId { get; set; }

        public District District { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Route> FromCity { get; set; }
        public virtual ICollection<Route> ToCity { get; set; }
    }
}