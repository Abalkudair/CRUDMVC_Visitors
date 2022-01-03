namespace visitors.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addrequireds : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Visitors", "IDNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Visitors", "vehicleType", c => c.String(nullable: false));
            AlterColumn("dbo.Visitors", "plateNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Visitors", "destination", c => c.String(nullable: false));
            AlterColumn("dbo.Visitors", "entryDate", c => c.String(nullable: false));
            AlterColumn("dbo.Visitors", "entryTime", c => c.String(nullable: false));
            AlterColumn("dbo.Visitors", "exitDate", c => c.String(nullable: false));
            AlterColumn("dbo.Visitors", "exitTime", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Visitors", "exitTime", c => c.String());
            AlterColumn("dbo.Visitors", "exitDate", c => c.String());
            AlterColumn("dbo.Visitors", "entryTime", c => c.String());
            AlterColumn("dbo.Visitors", "entryDate", c => c.String());
            AlterColumn("dbo.Visitors", "destination", c => c.String());
            AlterColumn("dbo.Visitors", "plateNumber", c => c.String());
            AlterColumn("dbo.Visitors", "vehicleType", c => c.String());
            AlterColumn("dbo.Visitors", "IDNumber", c => c.String());
        }
    }
}
