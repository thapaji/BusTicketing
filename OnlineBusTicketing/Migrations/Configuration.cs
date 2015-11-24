namespace OnlineBusTicketing.Migrations
{
    using OnlineBusTicketing.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OnlineBusTicketing.Models.DAL.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(OnlineBusTicketing.Models.DAL.DataContext context)
        {
            var zones = new List<Zone>{
                new Zone{Name="Mechi"},
                new Zone{Name="Koshi"},
                new Zone{Name="Sagarmatha"},
                new Zone{Name="Janakpur"},
                new Zone{Name="Bagmati"},
                new Zone{Name="Narayani"},
                new Zone{Name="Lumbini"},
                new Zone{Name="Gandaki"},
                new Zone{Name="Karnali"},
                new Zone{Name="Dahulagiri"},
                new Zone{Name="Rapti"},
                new Zone{Name="Bheri"},
                new Zone{Name="Seti"},
                new Zone{Name="Mahakali"}
            };
            foreach (Zone zone in zones)
            {
                context.Zone.Add(zone);
            }
            context.SaveChanges();
        }
    }
}
