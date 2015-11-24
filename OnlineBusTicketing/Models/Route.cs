using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineBusTicketing.Models
{
    [Table("tbl_route")]
    public class Route
    {
        [Column("route_id")]
        public int RouteId { get; set; }

        [Column("price")]
        public int Price { get; set; }

        [Column("from_city_id")]
        public int FromCityId { get; set; }

        [Column("to_city_id")]
        public int ToCityId { get; set; }
       
        [ForeignKey("FromCityId")]
        public City FromCity { get; set; }
       
        [ForeignKey("ToCityId")]
        public City ToCity { get; set; }
        public virtual ICollection<Departure> Departures { get; set; }
    }
}