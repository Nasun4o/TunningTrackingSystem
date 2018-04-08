namespace HppTuning.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntitiyChanges : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cars", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Cars", new[] { "ApplicationUser_Id" });
            AddColumn("dbo.AspNetUsers", "Car_Id", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "Car_Id");
            AddForeignKey("dbo.AspNetUsers", "Car_Id", "dbo.Cars", "Id");
            DropColumn("dbo.Cars", "ApplicationUser_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "ApplicationUser_Id", c => c.String(maxLength: 128));
            DropForeignKey("dbo.AspNetUsers", "Car_Id", "dbo.Cars");
            DropIndex("dbo.AspNetUsers", new[] { "Car_Id" });
            DropColumn("dbo.AspNetUsers", "Car_Id");
            CreateIndex("dbo.Cars", "ApplicationUser_Id");
            AddForeignKey("dbo.Cars", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
