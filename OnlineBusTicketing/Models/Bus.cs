using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineBusTicketing.Models
{
    [Table("tbl_bus")]
    public class Bus
    {
        [Column("bus_id")]
        public int BusId { get; set; }

        [Column("no_plate")]
        public String NoPlate { get; set; }

        [Column("no_of_seats_A")]
        public int NoOfSeatsA { get; set; }

        [Column("no_of_seats_B")]
        public int NoOfSeatsB { get; set; }

        [Column("company_id")]
        public int CompanyId { get; set; }


        public Company Company { get; set; }
        public virtual ICollection<Departure> Departures { get; set; }

    }
}