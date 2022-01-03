namespace visitors.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addvalidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Visitors", "IDNumber", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Visitors", "plateNumber", c => c.String(nullable: false, maxLength: 4));
            AlterColumn("dbo.Visitors", "entryDate", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Visitors", "entryTime", c => c.String(nullable: false, maxLength: 5));
            AlterColumn("dbo.Visitors", "exitDate", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Visitors", "exitTime", c => c.String(nullable: false, maxLength: 5));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Visitors", "exitTime", c => c.String(nullable: false));
            AlterColumn("dbo.Visitors", "exitDate", c => c.String(nullable: false));
            AlterColumn("dbo.Visitors", "entryTime", c => c.String(nullable: false));
            AlterColumn("dbo.Visitors", "entryDate", c => c.String(nullable: false));
            AlterColumn("dbo.Visitors", "plateNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Visitors", "IDNumber", c => c.String(nullable: false));
        }
    }
}
