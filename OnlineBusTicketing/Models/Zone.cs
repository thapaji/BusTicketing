using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineBusTicketing.Models
{
    [Table("tbl_zone")]
    public class Zone
    {
        [Column("zone_id")]
        public int ZoneId { get; set; }
        
        [Column("zone_name")]
        public String Name { get; set; }
        public virtual ICollection<District> Districts { get; set; }
    }
}