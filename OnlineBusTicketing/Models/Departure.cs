using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBusTicketing.Models
{
    [Table("tbl_departure")]
    public class Departure
    {
        [Column("departure_id")]
        public int DepartureId { get; set; }

        [Column("departure_date")]
        public DateTime DepartureDate { get; set; }

        [Column("departure_time")]
        public TimeSpan Time { get; set; }

        [Column("bus_id")]
        public int BusId { get; set; }

        [Column("route_id")]
        public int RouteId { get; set; }

        public Bus Bus { get; set; }
        public Route Route { get; set; }
    }
}