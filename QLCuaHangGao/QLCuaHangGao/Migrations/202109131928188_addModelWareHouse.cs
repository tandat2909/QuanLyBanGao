namespace QLCuaHangGao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addModelWareHouse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WareHouses",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        DateAdd = c.DateTime(nullable: false),
                        AmountAdd = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Inventory = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.ProductId, t.DateAdd })
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WareHouses", "ProductId", "dbo.Products");
            DropIndex("dbo.WareHouses", new[] { "ProductId" });
            DropTable("dbo.WareHouses");
        }
    }
}
