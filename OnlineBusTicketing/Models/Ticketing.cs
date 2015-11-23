using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineBusTicketing.Models
{
    public class Ticketing
    {
        public int TicketingId { get; set; }
        public Customer customerId { get; set; }
        public int NoOfSeat { get; set; }
        public String TicketNo { get; set; }
        public int StationId { get; set; }
        [ForeignKey("StationId")]
        public virtual City station { get; set; }
        public virtual Departure departureId { get; set; }
        public virtual ICollection<TicketingDetail> TicketingDetail { get; set; }
    }
}