namespace PruebaNewShore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Flights",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartureDate = c.DateTime(nullable: false),
                        FlightNumber = c.String(),
                        Price = c.Single(nullable: false),
                        Currency = c.String(),
                        ArrivalStation_Id = c.Int(),
                        DepartureStation_Id = c.Int(),
                        Booking_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Markets", t => t.ArrivalStation_Id)
                .ForeignKey("dbo.Markets", t => t.DepartureStation_Id)
                .ForeignKey("dbo.Bookings", t => t.Booking_Id)
                .Index(t => t.ArrivalStation_Id)
                .Index(t => t.DepartureStation_Id)
                .Index(t => t.Booking_Id);
            
            CreateTable(
                "dbo.Markets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IataCode = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Passengers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SurName = c.String(),
                        DateBirth = c.DateTime(nullable: false),
                        Phone = c.String(),
                        Email = c.String(),
                        Booking_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bookings", t => t.Booking_Id)
                .Index(t => t.Booking_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Passengers", "Booking_Id", "dbo.Bookings");
            DropForeignKey("dbo.Flights", "Booking_Id", "dbo.Bookings");
            DropForeignKey("dbo.Flights", "DepartureStation_Id", "dbo.Markets");
            DropForeignKey("dbo.Flights", "ArrivalStation_Id", "dbo.Markets");
            DropIndex("dbo.Passengers", new[] { "Booking_Id" });
            DropIndex("dbo.Flights", new[] { "Booking_Id" });
            DropIndex("dbo.Flights", new[] { "DepartureStation_Id" });
            DropIndex("dbo.Flights", new[] { "ArrivalStation_Id" });
            DropTable("dbo.Passengers");
            DropTable("dbo.Markets");
            DropTable("dbo.Flights");
            DropTable("dbo.Bookings");
        }
    }
}
