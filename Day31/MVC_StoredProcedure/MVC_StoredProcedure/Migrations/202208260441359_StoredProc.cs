namespace MVC_StoredProcedure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StoredProc : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
                "dbo.InsertEmployee",
                p => new
                    {
                        Name = p.String(),
                        Email = p.String(),
                        Phone = p.String(),
                        Position = p.String(),
                        DepartmentId = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Employees]([Name], [Email], [Phone], [Position], [DepartmentId])
                      VALUES (@Name, @Email, @Phone, @Position, @DepartmentId)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Employees]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Employees] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.UpdateEmployee",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                        Email = p.String(),
                        Phone = p.String(),
                        Position = p.String(),
                        DepartmentId = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Employees]
                      SET [Name] = @Name, [Email] = @Email, [Phone] = @Phone, [Position] = @Position, [DepartmentId] = @DepartmentId
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.DeleteEmployee",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Employees]
                      WHERE ([Id] = @Id)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.DeleteEmployee");
            DropStoredProcedure("dbo.UpdateEmployee");
            DropStoredProcedure("dbo.InsertEmployee");
        }
    }
}
