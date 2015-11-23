using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineBusTicketing.Models
{
    public class Route
    {
        public int RouteId { get; set; }
        public int Price { get; set; }
        public int FromCityId { get; set; }
        public int ToCityId { get; set; }
       
        [ForeignKey("FromCityId")]
        public City FromCity { get; set; }
       
        [ForeignKey("ToCityId")]
        public City ToCity { get; set; }
        public virtual ICollection<Departure> Departures { get; set; }
    }
}