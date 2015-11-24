using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBusTicketing.Models
{
    [Table("tbl_user")]
    public class User
    {
        [Column("user_id")]
        public int UserId { get; set; }

        [Column("user_name")]
        public String Username { get; set; }

        [Column("password")]
        public String Password { get; set; }

        [Column("verification_code")]
        public int VerificationCode { get; set; }

        [Column("email")]
        public String Email { get; set; }

        [Column("role_id")]
        public int RoleId { get; set; }

        public Role Role { get; set; }
    }
}