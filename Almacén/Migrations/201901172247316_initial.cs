namespace Almacén.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        LocId = c.Int(nullable: false, identity: true),
                        LocName = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.LocId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Locations");
        }
    }
}
