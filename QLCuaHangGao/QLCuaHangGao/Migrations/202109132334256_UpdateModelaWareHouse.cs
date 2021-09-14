namespace QLCuaHangGao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModelaWareHouse : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.WareHouses", "EmployeeUpdate_UserId", "dbo.Users");
            DropIndex("dbo.WareHouses", new[] { "EmployeeUpdate_UserId" });
            RenameColumn(table: "dbo.WareHouses", name: "EmployeeUpdate_UserId", newName: "UserId");
            AlterColumn("dbo.WareHouses", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.WareHouses", "UserId");
            AddForeignKey("dbo.WareHouses", "UserId", "dbo.Users", "UserId", cascadeDelete: true);
            DropColumn("dbo.WareHouses", "EmployeeUpdateId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WareHouses", "EmployeeUpdateId", c => c.Int(nullable: false));
            DropForeignKey("dbo.WareHouses", "UserId", "dbo.Users");
            DropIndex("dbo.WareHouses", new[] { "UserId" });
            AlterColumn("dbo.WareHouses", "UserId", c => c.Int());
            RenameColumn(table: "dbo.WareHouses", name: "UserId", newName: "EmployeeUpdate_UserId");
            CreateIndex("dbo.WareHouses", "EmployeeUpdate_UserId");
            AddForeignKey("dbo.WareHouses", "EmployeeUpdate_UserId", "dbo.Users", "UserId");
        }
    }
}
