namespace HppTuning.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MIniorChanges : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "Car_Id", "dbo.Cars");
            DropIndex("dbo.AspNetUsers", new[] { "Car_Id" });
            CreateTable(
                "dbo.SimpleNotUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        PhoneNumber = c.String(),
                        Car_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.Car_Id)
                .Index(t => t.Car_Id);
            
            DropColumn("dbo.AspNetUsers", "Car_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Car_Id", c => c.Int());
            DropForeignKey("dbo.SimpleNotUsers", "Car_Id", "dbo.Cars");
            DropIndex("dbo.SimpleNotUsers", new[] { "Car_Id" });
            DropTable("dbo.SimpleNotUsers");
            CreateIndex("dbo.AspNetUsers", "Car_Id");
            AddForeignKey("dbo.AspNetUsers", "Car_Id", "dbo.Cars", "Id");
        }
    }
}
