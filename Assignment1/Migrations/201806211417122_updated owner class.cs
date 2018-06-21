namespace Assignment1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedownerclass : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Vehicles", "Owner_Id", "dbo.Owners");
            DropIndex("dbo.Vehicles", new[] { "Owner_Id" });
            RenameColumn(table: "dbo.Vehicles", name: "Owner_Id", newName: "OwnerId");
            AlterColumn("dbo.Vehicles", "OwnerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Vehicles", "OwnerId");
            AddForeignKey("dbo.Vehicles", "OwnerId", "dbo.Owners", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "OwnerId", "dbo.Owners");
            DropIndex("dbo.Vehicles", new[] { "OwnerId" });
            AlterColumn("dbo.Vehicles", "OwnerId", c => c.Int());
            RenameColumn(table: "dbo.Vehicles", name: "OwnerId", newName: "Owner_Id");
            CreateIndex("dbo.Vehicles", "Owner_Id");
            AddForeignKey("dbo.Vehicles", "Owner_Id", "dbo.Owners", "Id");
        }
    }
}
