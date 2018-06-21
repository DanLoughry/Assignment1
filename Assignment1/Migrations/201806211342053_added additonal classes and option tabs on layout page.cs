namespace Assignment1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedadditonalclassesandoptiontabsonlayoutpage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VIN = c.Int(nullable: false),
                        Make = c.String(),
                        Model = c.String(),
                        Year = c.Int(nullable: false),
                        Owner_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Owners", t => t.Owner_Id)
                .Index(t => t.Owner_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "Owner_Id", "dbo.Owners");
            DropIndex("dbo.Vehicles", new[] { "Owner_Id" });
            DropTable("dbo.Vehicles");
        }
    }
}
