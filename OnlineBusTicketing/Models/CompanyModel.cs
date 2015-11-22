using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBusTicketing.Models
{
    public class CompanyModel
    {
        public int id { get; set; }
        public String name { get; set; }
        public DistrictModel district_id { get; set; }
        

    }
}