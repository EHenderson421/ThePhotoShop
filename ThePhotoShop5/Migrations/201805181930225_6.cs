namespace ThePhotoShop5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _6 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Reservations");
            AlterColumn("dbo.Reservations", "ReservationId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Reservations", "ReservationId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Reservations");
            AlterColumn("dbo.Reservations", "ReservationId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Reservations", "ReservationId");
        }
    }
}
