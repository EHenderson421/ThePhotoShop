namespace ThePhotoShop5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "AppointmentDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Reservations", "AppointmentTime", c => c.Single(nullable: false));
            DropColumn("dbo.Reservations", "AppointmentDateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "AppointmentDateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Reservations", "AppointmentTime");
            DropColumn("dbo.Reservations", "AppointmentDate");
        }
    }
}
