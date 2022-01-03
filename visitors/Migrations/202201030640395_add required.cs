namespace visitors.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addrequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Visitors", "driverName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Visitors", "driverName", c => c.String());
        }
    }
}
