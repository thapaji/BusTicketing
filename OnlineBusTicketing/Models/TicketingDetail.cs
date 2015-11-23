using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineBusTicketing.Models
{
    public class TicketingDetail
    {
        [Key]
        public int TicketingDetailId { get; set; }
        public String Name { get; set; }
        public int TicketingId { get; set; }
        public virtual Ticketing Ticketing { get; set; }
    }
}