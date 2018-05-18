namespace ThePhotoShop5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _5 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Locations");
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationId = c.String(nullable: false, maxLength: 128),
                        ClientId = c.Int(nullable: false),
                        LocationId = c.Int(nullable: false),
                        AppointmentDateTime = c.String(),
                        AppointmentConfirmation = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ReservationId)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.LocationId);
            
            AlterColumn("dbo.Locations", "LocationId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Locations", "LocationId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.Reservations", "ClientId", "dbo.Clients");
            DropIndex("dbo.Reservations", new[] { "LocationId" });
            DropIndex("dbo.Reservations", new[] { "ClientId" });
            DropPrimaryKey("dbo.Locations");
            AlterColumn("dbo.Locations", "LocationId", c => c.String(nullable: false, maxLength: 128));
            DropTable("dbo.Reservations");
            AddPrimaryKey("dbo.Locations", "LocationId");
        }
    }
}
