using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBusTicketing.Models
{
    public class User
    {
        public int UserId { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public int VerificationCode { get; set; }
        public String Email { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}