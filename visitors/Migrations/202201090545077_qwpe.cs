namespace visitors.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class qwpe : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Visitors", "entryTime", c => c.String(nullable: false));
            AlterColumn("dbo.Visitors", "exitTime", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Visitors", "exitTime", c => c.String(nullable: false, maxLength: 5));
            AlterColumn("dbo.Visitors", "entryTime", c => c.String(nullable: false, maxLength: 5));
        }
    }
}
