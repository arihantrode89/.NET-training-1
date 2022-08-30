namespace TaskCodeApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renameproc : DbMigration
    {
        public override void Up()
        {
            RenameStoredProcedure(name: "dbo.DeleteProdcut", newName: "DeleteProduct");
        }
        
        public override void Down()
        {
            RenameStoredProcedure(name: "dbo.DeleteProduct", newName: "DeleteProdcut");
        }
    }
}
