namespace HppTuning.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SolidChangesOnUserStructure : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.SimpleNotUsers", newName: "MyUserInfoes");
            RenameColumn(table: "dbo.Parts", name: "CarId", newName: "Cars_Id");
            RenameColumn(table: "dbo.Cars", name: "SimpleNotUserId", newName: "MyUserInfo_Id");
            RenameColumn(table: "dbo.RacingHistories", name: "SimpleNotUser_Id", newName: "MyUserInfo_Id");
            RenameIndex(table: "dbo.Cars", name: "IX_SimpleNotUserId", newName: "IX_MyUserInfo_Id");
            RenameIndex(table: "dbo.RacingHistories", name: "IX_SimpleNotUser_Id", newName: "IX_MyUserInfo_Id");
            RenameIndex(table: "dbo.Parts", name: "IX_CarId", newName: "IX_Cars_Id");
            AddColumn("dbo.Cars", "AppUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetUsers", "MyUserInfo_Id", c => c.Int());
            CreateIndex("dbo.Cars", "AppUser_Id");
            CreateIndex("dbo.AspNetUsers", "MyUserInfo_Id");
            AddForeignKey("dbo.AspNetUsers", "MyUserInfo_Id", "dbo.MyUserInfoes", "Id");
            AddForeignKey("dbo.Cars", "AppUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "AppUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "MyUserInfo_Id", "dbo.MyUserInfoes");
            DropIndex("dbo.AspNetUsers", new[] { "MyUserInfo_Id" });
            DropIndex("dbo.Cars", new[] { "AppUser_Id" });
            DropColumn("dbo.AspNetUsers", "MyUserInfo_Id");
            DropColumn("dbo.Cars", "AppUser_Id");
            RenameIndex(table: "dbo.Parts", name: "IX_Cars_Id", newName: "IX_CarId");
            RenameIndex(table: "dbo.RacingHistories", name: "IX_MyUserInfo_Id", newName: "IX_SimpleNotUser_Id");
            RenameIndex(table: "dbo.Cars", name: "IX_MyUserInfo_Id", newName: "IX_SimpleNotUserId");
            RenameColumn(table: "dbo.RacingHistories", name: "MyUserInfo_Id", newName: "SimpleNotUser_Id");
            RenameColumn(table: "dbo.Cars", name: "MyUserInfo_Id", newName: "SimpleNotUserId");
            RenameColumn(table: "dbo.Parts", name: "Cars_Id", newName: "CarId");
            RenameTable(name: "dbo.MyUserInfoes", newName: "SimpleNotUsers");
        }
    }
}
