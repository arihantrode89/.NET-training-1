namespace MVC_StoredProcedure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SP : DbMigration
    {
        public override void Up()
        {
            //DropStoredProcedure("dbo.InsertEmployee");
            //DropStoredProcedure("dbo.UpdateEmployee");
            //DropStoredProcedure("dbo.DeleteEmployee");
        }
        
        public override void Down()
        {
            throw new NotSupportedException("Scaffolding create or alter procedure operations is not supported in down methods.");
        }
    }
}
