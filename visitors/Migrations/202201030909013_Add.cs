namespace visitors.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Visitors", "plateNumber");
            DropColumn("dbo.Visitors", "destination");
            DropColumn("dbo.Visitors", "entryDate");
            DropColumn("dbo.Visitors", "entryTime");
            DropColumn("dbo.Visitors", "exitDate");
            DropColumn("dbo.Visitors", "exitTime");
            DropColumn("dbo.Visitors", "isVisitor");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Visitors", "isVisitor", c => c.String(nullable: false));
            AddColumn("dbo.Visitors", "exitTime", c => c.String(nullable: false, maxLength: 5));
            AddColumn("dbo.Visitors", "exitDate", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.Visitors", "entryTime", c => c.String(nullable: false, maxLength: 5));
            AddColumn("dbo.Visitors", "entryDate", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.Visitors", "destination", c => c.String(nullable: false));
            AddColumn("dbo.Visitors", "plateNumber", c => c.String(nullable: false, maxLength: 4));
        }
    }
}
