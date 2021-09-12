namespace QLCuaHangGao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTotalFieldOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "total");
        }
    }
}
