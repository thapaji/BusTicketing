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
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(OnlineBusTicketing.Models.DAL.DataContext context)
        {
            if (!context.Zone.Any())
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

            if (!context.District.Any())
            {
                var districts = new List<District>{
                new District{Name="Ilam", ZoneId=1},
                new District{Name="Jhapa", ZoneId=1},
                new District{Name="Panchthar", ZoneId=1},
                new District{Name="Taplejung", ZoneId=1},
                new District{Name="Bhojpur", ZoneId=2},
                new District{Name="Dhankuta", ZoneId=2},
                new District{Name="Morang", ZoneId=2},
                new District{Name="Sankhuwasabha", ZoneId=2},
                new District{Name="Sunsari", ZoneId=2},
                new District{Name="Terhathum", ZoneId=2},
                new District{Name="Khotang", ZoneId=3},
                new District{Name="Okhaldhunga", ZoneId=3},
                new District{Name="Saptari", ZoneId=3},
                new District{Name="Siraha", ZoneId=3},
                 new District{Name="Solukhumbu", ZoneId=3},
                new District{Name="Udayapur", ZoneId=3},
                new District{Name="Dhanusa", ZoneId=4},
                new District{Name="Dholkha", ZoneId=4},
                new District{Name="Mahottari", ZoneId=4},
                new District{Name="Ramechhap", ZoneId=4},
                new District{Name="Sarlahi", ZoneId=4},
                new District{Name="Sindhuli", ZoneId=4},
                new District{Name="Bhaktapur", ZoneId=5},
                new District{Name="Dhading", ZoneId=5},
                new District{Name="Kathmandu", ZoneId=5},
                new District{Name="Kavrepalanchok", ZoneId=5},
                new District{Name="Lalitpur", ZoneId=5},
                new District{Name="Nuwakot", ZoneId=5},
                 new District{Name="Rasuwa", ZoneId=5},
                new District{Name="Sindhupalchok", ZoneId=5},
                new District{Name="Bara", ZoneId=6},
                new District{Name="Chitwan", ZoneId=6},
                new District{Name="Makwanpur", ZoneId=6},
                new District{Name="Parsa", ZoneId=6},
                new District{Name="Rautahat", ZoneId=6},
                new District{Name="Arghakhanchi", ZoneId=7},
                new District{Name="Gulmi", ZoneId=7},
                new District{Name="Kapilvastu", ZoneId=7},
                new District{Name="Nawalparasi", ZoneId=7},
                new District{Name="Palpa", ZoneId=7},
                new District{Name="Rupandehi", ZoneId=7},
                new District{Name="Gorkha", ZoneId=8},
                 new District{Name="Kaski", ZoneId=8},
                new District{Name="Lamjung", ZoneId=8},
                new District{Name="Manang", ZoneId=8},
                new District{Name="Syangja", ZoneId=8},
                new District{Name="Tanahu", ZoneId=8},
                new District{Name="Dolpa", ZoneId=9},
                new District{Name="Humla", ZoneId=9},
                new District{Name="Jumla", ZoneId=9},
                new District{Name="Kalikot", ZoneId=9},
                new District{Name="Mugu", ZoneId=9},
                new District{Name="Baglung", ZoneId=10},
                new District{Name="Mustang", ZoneId=10},
                new District{Name="Myagdi", ZoneId=10},
                new District{Name="Parbat", ZoneId=10},
                  new District{Name="Dang Deokhuri", ZoneId=11},
                new District{Name="Pyuthan", ZoneId=11},
                new District{Name="Rolpa", ZoneId=11},
                new District{Name="Rukum", ZoneId=11},
                 new District{Name="Salyan", ZoneId=11},
                new District{Name="Banke", ZoneId=12},
                new District{Name="Bardiya", ZoneId=12},
                new District{Name="Dailekh", ZoneId=12},
                new District{Name="Jajarkot", ZoneId=12},
                new District{Name="Surkhet", ZoneId=12},
                new District{Name="Achham", ZoneId=13},
                new District{Name="Bajhang", ZoneId=13},
                new District{Name="Bajura", ZoneId=13},
                new District{Name="Doti", ZoneId=13},
                new District{Name="Kailali", ZoneId=13},
                new District{Name="Baitadi", ZoneId=14},
                new District{Name="Dadeldhura", ZoneId=14},
                new District{Name="Darchula", ZoneId=14},
                 new District{Name="Kanchanpur", ZoneId=14},
            
            };
                foreach (District district in districts)
                {
                    context.District.Add(district);
                }
                context.SaveChanges();

            }
        }
    }
}
