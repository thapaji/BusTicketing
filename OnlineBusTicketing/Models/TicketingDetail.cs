using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineBusTicketing.Models
{
    [Table("tbl_ticketing_detail")]
    public class TicketingDetail
    {
        [Column("ticketing_detail_id")]
        public int TicketingDetailId { get; set; }

        [Column("customer_name")]
        public String CustomerName { get; set; }

        [Column("ticketing_id")]
        public int TicketingId { get; set; }

        public virtual Ticketing Ticketing { get; set; }
    }
}