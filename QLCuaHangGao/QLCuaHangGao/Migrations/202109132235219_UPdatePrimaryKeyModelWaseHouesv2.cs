namespace QLCuaHangGao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UPdatePrimaryKeyModelWaseHouesv2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.WareHouses");
            AddPrimaryKey("dbo.WareHouses", new[] { "WareHouseId", "ProductId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.WareHouses");
            AddPrimaryKey("dbo.WareHouses", new[] { "ProductId", "WareHouseId" });
        }
    }
}
