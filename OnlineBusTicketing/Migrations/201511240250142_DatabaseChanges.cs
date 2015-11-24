namespace OnlineBusTicketing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseChanges : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bus",
                c => new
                    {
                        BusId = c.Int(nullable: false, identity: true),
                        NoPlate = c.String(),
                        NoOfSeatsA = c.Int(nullable: false),
                        NoOfSeatsB = c.Int(nullable: false),
                        CompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BusId)
                .ForeignKey("dbo.Company", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DistrictId = c.Int(nullable: false),
                        City_CityId = c.Int(),
                    })
                .PrimaryKey(t => t.CompanyId)
                .ForeignKey("dbo.City", t => t.City_CityId)
                .ForeignKey("dbo.District", t => t.DistrictId, cascadeDelete: true)
                .Index(t => t.DistrictId)
                .Index(t => t.City_CityId);
            
            CreateTable(
                "dbo.District",
                c => new
                    {
                        DistrictId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ZoneId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DistrictId)
                .ForeignKey("dbo.Zone", t => t.ZoneId, cascadeDelete: true)
                .Index(t => t.ZoneId);
            
            CreateTable(
                "dbo.City",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DistrictId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CityId)
                .ForeignKey("dbo.District", t => t.DistrictId, cascadeDelete: true)
                .Index(t => t.DistrictId);
            
            CreateTable(
                "dbo.Route",
                c => new
                    {
                        RouteId = c.Int(nullable: false, identity: true),
                        Price = c.Int(nullable: false),
                        FromCityId = c.Int(nullable: false),
                        ToCityId = c.Int(nullable: false),
                        City_CityId = c.Int(),
                        City_CityId1 = c.Int(),
                    })
                .PrimaryKey(t => t.RouteId)
                .ForeignKey("dbo.City", t => t.FromCityId, cascadeDelete: false)
                .ForeignKey("dbo.City", t => t.ToCityId, cascadeDelete: false)
                .ForeignKey("dbo.City", t => t.City_CityId)
                .ForeignKey("dbo.City", t => t.City_CityId1)
                .Index(t => t.FromCityId)
                .Index(t => t.ToCityId)
                .Index(t => t.City_CityId)
                .Index(t => t.City_CityId1);
            
            CreateTable(
                "dbo.Departure",
                c => new
                    {
                        DepartureId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Time = c.Time(nullable: false, precision: 7),
                        BusId = c.Int(nullable: false),
                        RouteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DepartureId)
                .ForeignKey("dbo.Bus", t => t.BusId, cascadeDelete: true)
                .ForeignKey("dbo.Route", t => t.RouteId, cascadeDelete: true)
                .Index(t => t.BusId)
                .Index(t => t.RouteId);
            
            CreateTable(
                "dbo.Zone",
                c => new
                    {
                        ZoneId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ZoneId);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateTable(
                "dbo.Ticketing",
                c => new
                    {
                        TicketingId = c.Int(nullable: false, identity: true),
                        NoOfSeat = c.Int(nullable: false),
                        TicketNo = c.String(),
                        StationId = c.Int(nullable: false),
                        customerId_CustomerId = c.Int(),
                        departureId_DepartureId = c.Int(),
                    })
                .PrimaryKey(t => t.TicketingId)
                .ForeignKey("dbo.Customer", t => t.customerId_CustomerId)
                .ForeignKey("dbo.Departure", t => t.departureId_DepartureId)
                .ForeignKey("dbo.City", t => t.StationId, cascadeDelete: true)
                .Index(t => t.StationId)
                .Index(t => t.customerId_CustomerId)
                .Index(t => t.departureId_DepartureId);
            
            CreateTable(
                "dbo.TicketingDetail",
                c => new
                    {
                        TicketingDetailId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TicketingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TicketingDetailId)
                .ForeignKey("dbo.Ticketing", t => t.TicketingId, cascadeDelete: true)
                .Index(t => t.TicketingId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        VerificationCode = c.Int(nullable: false),
                        Email = c.String(),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Role", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "RoleId", "dbo.Role");
            DropForeignKey("dbo.TicketingDetail", "TicketingId", "dbo.Ticketing");
            DropForeignKey("dbo.Ticketing", "StationId", "dbo.City");
            DropForeignKey("dbo.Ticketing", "departureId_DepartureId", "dbo.Departure");
            DropForeignKey("dbo.Ticketing", "customerId_CustomerId", "dbo.Customer");
            DropForeignKey("dbo.Company", "DistrictId", "dbo.District");
            DropForeignKey("dbo.District", "ZoneId", "dbo.Zone");
            DropForeignKey("dbo.Route", "City_CityId1", "dbo.City");
            DropForeignKey("dbo.Route", "City_CityId", "dbo.City");
            DropForeignKey("dbo.Route", "ToCityId", "dbo.City");
            DropForeignKey("dbo.Route", "FromCityId", "dbo.City");
            DropForeignKey("dbo.Departure", "RouteId", "dbo.Route");
            DropForeignKey("dbo.Departure", "BusId", "dbo.Bus");
            DropForeignKey("dbo.City", "DistrictId", "dbo.District");
            DropForeignKey("dbo.Company", "City_CityId", "dbo.City");
            DropForeignKey("dbo.Bus", "CompanyId", "dbo.Company");
            DropIndex("dbo.User", new[] { "RoleId" });
            DropIndex("dbo.TicketingDetail", new[] { "TicketingId" });
            DropIndex("dbo.Ticketing", new[] { "departureId_DepartureId" });
            DropIndex("dbo.Ticketing", new[] { "customerId_CustomerId" });
            DropIndex("dbo.Ticketing", new[] { "StationId" });
            DropIndex("dbo.Departure", new[] { "RouteId" });
            DropIndex("dbo.Departure", new[] { "BusId" });
            DropIndex("dbo.Route", new[] { "City_CityId1" });
            DropIndex("dbo.Route", new[] { "City_CityId" });
            DropIndex("dbo.Route", new[] { "ToCityId" });
            DropIndex("dbo.Route", new[] { "FromCityId" });
            DropIndex("dbo.City", new[] { "DistrictId" });
            DropIndex("dbo.District", new[] { "ZoneId" });
            DropIndex("dbo.Company", new[] { "City_CityId" });
            DropIndex("dbo.Company", new[] { "DistrictId" });
            DropIndex("dbo.Bus", new[] { "CompanyId" });
            DropTable("dbo.User");
            DropTable("dbo.TicketingDetail");
            DropTable("dbo.Ticketing");
            DropTable("dbo.Role");
            DropTable("dbo.Customer");
            DropTable("dbo.Zone");
            DropTable("dbo.Departure");
            DropTable("dbo.Route");
            DropTable("dbo.City");
            DropTable("dbo.District");
            DropTable("dbo.Company");
            DropTable("dbo.Bus");
        }
    }
}
