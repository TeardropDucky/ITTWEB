namespace HandIn2_FoodProcessor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMigrationNumber2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Consumables", "User_UserId", "dbo.UserInfoes");
            DropIndex("dbo.Consumables", new[] { "User_UserId" });
            DropColumn("dbo.Consumables", "User_UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Consumables", "User_UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Consumables", "User_UserId");
            AddForeignKey("dbo.Consumables", "User_UserId", "dbo.UserInfoes", "UserId");
        }
    }
}
