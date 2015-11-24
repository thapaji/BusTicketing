using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBusTicketing.Models
{
    [Table("tbl_role")]
    public class Role
    {
        [Column("role_id")]
        public int RoleId { get; set; }

        [Column("role_name")]
        public String Name { get; set; }
    }
}