namespace visitors.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Visitors", "vehicleType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Visitors", "vehicleType", c => c.String(nullable: false));
        }
    }
}
