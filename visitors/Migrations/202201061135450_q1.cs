namespace visitors.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class q1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Visitors", "entryDate", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Visitors", "entryDate", c => c.String(nullable: false, maxLength: 10));
        }
    }
}
