using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBusTicketing.Models
{
    [Table("tbl_customer")]
    public class Customer
    {
        [Column("customer_id")]
        public int CustomerId { get; set; }

        [Column("customer_name")]
        public String Name { get; set; }
    }
}