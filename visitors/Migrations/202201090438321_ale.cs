namespace visitors.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ale : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Visitors", "exitDate", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Visitors", "exitDate", c => c.String(nullable: false, maxLength: 10));
        }
    }
}
