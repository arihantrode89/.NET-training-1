namespace MVC_StoredProcedure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StoredProcedure : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Phone = c.String(),
                        Position = c.String(),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
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
            DropForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "DepartmentId" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
