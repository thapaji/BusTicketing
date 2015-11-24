using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineBusTicketing.Models
{
    [Table("tbl_ticketing")]
    public class Ticketing
    {
        [Column("ticketing_id")]
        public int TicketingId { get; set; }

        [Column("customer_id")]
        public Customer customerId { get; set; }

        [Column("no_of_seats")]
        public int NoOfSeat { get; set; }

        [Column("ticket_no")]
        public String TicketNo { get; set; }

        [Column("station_id")]
        public int StationId { get; set; }

        [ForeignKey("StationId")]
        public virtual City Station { get; set; }
        public virtual Departure departureId { get; set; }
        public virtual ICollection<TicketingDetail> TicketingDetail { get; set; }
    }
}