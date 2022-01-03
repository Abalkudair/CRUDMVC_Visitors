namespace visitors.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Visitors",
                c => new
                    {
                        supplierName = c.String(nullable: false, maxLength: 128),
                        driverName = c.String(),
                        IDNumber = c.String(),
                        vehicleType = c.String(),
                        plateNumber = c.String(),
                        destination = c.String(),
                        entryDate = c.String(),
                        entryTime = c.String(),
                        exitDate = c.String(),
                        exitTime = c.String(),
                        isVisitor = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.supplierName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Visitors");
        }
    }
}
