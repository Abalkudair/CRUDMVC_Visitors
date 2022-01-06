namespace visitors.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Visitors", "supplierName", c => c.String());
            AlterColumn("dbo.Visitors", "vehicleType", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Visitors", "vehicleType", c => c.Int(nullable: false));
            AlterColumn("dbo.Visitors", "supplierName", c => c.String(nullable: false));
        }
    }
}
