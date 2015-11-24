using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineBusTicketing.Models.DAL
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=dataConnection")
        {
        }
        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Zone> Zone { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Route> Route { get; set; }
        public DbSet<Bus> Bus { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Departure> Departure { get; set; }
        public DbSet<Ticketing> Ticketing { get; set; }
        public DbSet<TicketingDetail> TicketingDetails { get; set; }
    }
}