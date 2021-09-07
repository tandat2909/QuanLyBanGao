namespace DBA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataPermission : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Roles([Name],[CreateDate]) values (N'Admin','20210905 10:34:09 AM')");
            Sql("Insert into Roles([Name],[CreateDate]) values (N'Employee','20210905 10:34:09 AM')");
            

        }
        
        public override void Down()
        {
        }
    }
}
