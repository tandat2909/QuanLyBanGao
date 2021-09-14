namespace QLCuaHangGao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPrimarykeyModelWarehouse : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.WareHouses");
            AddColumn("dbo.WareHouses", "WareHouseId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.WareHouses", new[] { "ProductId", "WareHouseId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.WareHouses");
            DropColumn("dbo.WareHouses", "WareHouseId");
            AddPrimaryKey("dbo.WareHouses", new[] { "ProductId", "DateAdd" });
        }
    }
}
