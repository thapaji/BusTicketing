using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBusTicketing.Models.DAL
{
    public class MasterDatabaseInitializer : System.Data.Entity .DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var zones = new List<Zone>{
                new Zone{ZoneId=1,Name="Mechi"},
                new Zone{ZoneId=2,Name="Koshi"},
                new Zone{ZoneId=3,Name="Sagarmatha"},
                new Zone{ZoneId=4,Name="Janakpur"},
                new Zone{ZoneId=5,Name="Bagmati"},
                new Zone{ZoneId=6,Name="Narayani"},
                new Zone{ZoneId=7,Name="Lumbini"},
                new Zone{ZoneId=8,Name="Gandaki"},
                new Zone{ZoneId=9,Name="Karnali"},
                new Zone{ZoneId=10,Name="Dahulagiri"},
                new Zone{ZoneId=11,Name="Rapti"},
                new Zone{ZoneId=12,Name="Bheri"},
                new Zone{ZoneId=13,Name="Seti"},
                new Zone{ZoneId=14,Name="Mahakali"}
            };
            foreach (Zone zone in zones)
            {
                context.Zone.Add(zone);
            }
            context.SaveChanges();
        }
    }
}