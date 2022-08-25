namespace MVC_Entity_Practice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Arihant : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Name", c => c.String());
        }
    }
}
