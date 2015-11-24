using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBusTicketing.Models
{
    [Table("tbl_company")]
    public class Company
    {
        [Column("company_id")]
        public int CompanyId { get; set; }

        [Column("company_name")]
        public String Name { get; set; }

        [Column("district_name")]
        public int DistrictId { get; set; }

        public District District { get; set; }
        public virtual ICollection<Bus> Buses { get; set; }
    }
}