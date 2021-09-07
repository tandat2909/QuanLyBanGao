namespace DBA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataCategory : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Categories([CategoryName]) values (N'Gạo')");
            Sql("Insert into Categories([CategoryName]) values (N'Nếp')");
        }
        
        public override void Down()
        {
        }
    }
}
