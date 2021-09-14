namespace QLCuaHangGao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addColUserModelWareHouse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WareHouses", "EmployeeUpdateId", c => c.Int(nullable: false));
            AddColumn("dbo.WareHouses", "EmployeeUpdate_UserId", c => c.Int());
            CreateIndex("dbo.WareHouses", "EmployeeUpdate_UserId");
            AddForeignKey("dbo.WareHouses", "EmployeeUpdate_UserId", "dbo.Users", "UserId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WareHouses", "EmployeeUpdate_UserId", "dbo.Users");
            DropIndex("dbo.WareHouses", new[] { "EmployeeUpdate_UserId" });
            DropColumn("dbo.WareHouses", "EmployeeUpdate_UserId");
            DropColumn("dbo.WareHouses", "EmployeeUpdateId");
        }
    }
}
