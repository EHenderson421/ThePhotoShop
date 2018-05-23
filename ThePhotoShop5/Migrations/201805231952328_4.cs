namespace ThePhotoShop5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reservations", "AppointmentTime", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reservations", "AppointmentTime", c => c.Single(nullable: false));
        }
    }
}
