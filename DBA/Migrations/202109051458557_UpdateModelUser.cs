namespace DBA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModelUser : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Password", c => c.String(maxLength: 300));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Password", c => c.String(maxLength: 200));
        }
    }
}
