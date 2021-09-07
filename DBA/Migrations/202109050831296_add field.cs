namespace DBA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addfield : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.OrderDetails", new[] { "ProductId" });
            AddColumn("dbo.Categories", "is_active", c => c.Boolean(nullable: false));
            AddColumn("dbo.Orders", "is_active", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "is_active", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "is_active", c => c.Boolean(nullable: false));
            AddColumn("dbo.Products", "is_active", c => c.Boolean(nullable: false));
            AddColumn("dbo.Products", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            CreateIndex("dbo.Categories", "CategoryName", unique: true);
            CreateIndex("dbo.OrderDetails", "ProductId", unique: true);
            CreateIndex("dbo.Users", "UserName", unique: true);
            CreateIndex("dbo.Roles", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Roles", new[] { "Name" });
            DropIndex("dbo.Users", new[] { "UserName" });
            DropIndex("dbo.OrderDetails", new[] { "ProductId" });
            DropIndex("dbo.Categories", new[] { "CategoryName" });
            DropColumn("dbo.Products", "Amount");
            DropColumn("dbo.Products", "is_active");
            DropColumn("dbo.Roles", "is_active");
            DropColumn("dbo.Users", "is_active");
            DropColumn("dbo.Orders", "is_active");
            DropColumn("dbo.Categories", "is_active");
            CreateIndex("dbo.OrderDetails", "ProductId");
        }
    }
}
