namespace visitors.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Visitors", "isVisitor", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Visitors", "isVisitor", c => c.Boolean(nullable: false));
        }
    }
}
