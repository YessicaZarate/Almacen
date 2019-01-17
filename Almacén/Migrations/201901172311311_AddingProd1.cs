namespace Almacén.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingProd1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProdId = c.Int(nullable: false, identity: true),
                        Item = c.String(),
                        Description = c.String(),
                        Qty = c.Int(nullable: false),
                        Cost = c.Double(nullable: false),
                        Price = c.Double(nullable: false),
                        LocId = c.Int(nullable: false),
                        ProvId = c.Int(nullable: false),
                        BrandId = c.Int(nullable: false),
                        LocationId = c.Int(nullable: false),
                        Warranty = c.Int(nullable: false),
                        DateAd = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.ProdId)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: true)
                .Index(t => t.LocationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "LocationId", "dbo.Locations");
            DropIndex("dbo.Products", new[] { "LocationId" });
            DropTable("dbo.Products");
        }
    }
}
