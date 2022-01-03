namespace visitors.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class q : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Visitors");
            AddColumn("dbo.Visitors", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Visitors", "supplierName", c => c.String());
            AddPrimaryKey("dbo.Visitors", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Visitors");
            AlterColumn("dbo.Visitors", "supplierName", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Visitors", "Id");
            AddPrimaryKey("dbo.Visitors", "supplierName");
        }
    }
}
