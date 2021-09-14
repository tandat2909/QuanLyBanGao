namespace QLCuaHangGao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletePrimaryProductKeyModelWaseHoues : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.WareHouses");
            AlterColumn("dbo.WareHouses", "WareHouseId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.WareHouses", "WareHouseId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.WareHouses");
            AlterColumn("dbo.WareHouses", "WareHouseId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.WareHouses", new[] { "WareHouseId", "ProductId" });
        }
    }
}
