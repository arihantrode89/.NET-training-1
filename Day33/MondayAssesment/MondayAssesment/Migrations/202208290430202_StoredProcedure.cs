namespace MondayAssesment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StoredProcedure : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
                "dbo.InsertEmployee",
                p => new
                    {
                        Name = p.String(),
                        Gender = p.String(),
                        City = p.String(),
                        Salary = p.Single(),
                        DepartmentId = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Employees]([Name], [Gender], [City], [Salary], [DepartmentId])
                      VALUES (@Name, @Gender, @City, @Salary, @DepartmentId)
                      
                      DECLARE @EmployeeId int
                      SELECT @EmployeeId = [EmployeeId]
                      FROM [dbo].[Employees]
                      WHERE @@ROWCOUNT > 0 AND [EmployeeId] = scope_identity()
                      
                      SELECT t0.[EmployeeId]
                      FROM [dbo].[Employees] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[EmployeeId] = @EmployeeId"
            );
            
            CreateStoredProcedure(
                "dbo.UpdateEmployee",
                p => new
                    {
                        EmployeeId = p.Int(),
                        Name = p.String(),
                        Gender = p.String(),
                        City = p.String(),
                        Salary = p.Single(),
                        DepartmentId = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Employees]
                      SET [Name] = @Name, [Gender] = @Gender, [City] = @City, [Salary] = @Salary, [DepartmentId] = @DepartmentId
                      WHERE ([EmployeeId] = @EmployeeId)"
            );
            
            CreateStoredProcedure(
                "dbo.DeleteEmployee",
                p => new
                    {
                        EmployeeId = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Employees]
                      WHERE ([EmployeeId] = @EmployeeId)"
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
