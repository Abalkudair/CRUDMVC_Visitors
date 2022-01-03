﻿namespace visitors.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Visitors", "plateNumber", c => c.String(nullable: false, maxLength: 4));
            AddColumn("dbo.Visitors", "destination", c => c.String(nullable: false));
            AddColumn("dbo.Visitors", "entryDate", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.Visitors", "entryTime", c => c.String(nullable: false, maxLength: 5));
            AddColumn("dbo.Visitors", "exitDate", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.Visitors", "exitTime", c => c.String(nullable: false, maxLength: 5));
            AddColumn("dbo.Visitors", "isVisitor", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Visitors", "isVisitor");
            DropColumn("dbo.Visitors", "exitTime");
            DropColumn("dbo.Visitors", "exitDate");
            DropColumn("dbo.Visitors", "entryTime");
            DropColumn("dbo.Visitors", "entryDate");
            DropColumn("dbo.Visitors", "destination");
            DropColumn("dbo.Visitors", "plateNumber");
        }
    }
}
