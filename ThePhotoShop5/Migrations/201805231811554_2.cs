namespace ThePhotoShop5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Invoices", "AmountDue", c => c.Single(nullable: false));
            AlterColumn("dbo.Reservations", "AppointmentDateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reservations", "AppointmentDateTime", c => c.String());
            AlterColumn("dbo.Invoices", "AmountDue", c => c.Double(nullable: false));
        }
    }
}
