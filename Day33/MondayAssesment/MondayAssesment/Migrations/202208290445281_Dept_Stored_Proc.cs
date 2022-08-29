namespace MondayAssesment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dept_Stored_Proc : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
                "dbo.InsertDepartment",
                p => new
                    {
                        DeptName = p.String(),
                    },
                body:
                    @"INSERT [dbo].[Departments]([DeptName])
                      VALUES (@DeptName)
                      
                      DECLARE @DeptId int
                      SELECT @DeptId = [DeptId]
                      FROM [dbo].[Departments]
                      WHERE @@ROWCOUNT > 0 AND [DeptId] = scope_identity()
                      
                      SELECT t0.[DeptId]
                      FROM [dbo].[Departments] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[DeptId] = @DeptId"
            );
            
            CreateStoredProcedure(
                "dbo.UpdateDepartment",
                p => new
                    {
                        DeptId = p.Int(),
                        DeptName = p.String(),
                    },
                body:
                    @"UPDATE [dbo].[Departments]
                      SET [DeptName] = @DeptName
                      WHERE ([DeptId] = @DeptId)"
            );
            
            CreateStoredProcedure(
                "dbo.DeleteDepartment",
                p => new
                    {
                        DeptId = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Departments]
                      WHERE ([DeptId] = @DeptId)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.DeleteDepartment");
            DropStoredProcedure("dbo.UpdateDepartment");
            DropStoredProcedure("dbo.InsertDepartment");
        }
    }
}
