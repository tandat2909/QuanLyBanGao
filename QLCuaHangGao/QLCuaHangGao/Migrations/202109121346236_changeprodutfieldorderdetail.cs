namespace QLCuaHangGao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeprodutfieldorderdetail : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.OrderDetails", new[] { "ProductId" });
            CreateIndex("dbo.OrderDetails", "ProductId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.OrderDetails", new[] { "ProductId" });
            CreateIndex("dbo.OrderDetails", "ProductId", unique: true);
        }
    }
}