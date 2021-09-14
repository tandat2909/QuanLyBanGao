namespace QLCuaHangGao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UPdatePrimaryKeyModelWaseHoues : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.WareHouses");
            AlterColumn("dbo.WareHouses", "WareHouseId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.WareHouses", new[] { "ProductId", "WareHouseId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.WareHouses");
            AlterColumn("dbo.WareHouses", "WareHouseId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.WareHouses", new[] { "ProductId", "WareHouseId" });
        }
    }
}
