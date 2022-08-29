namespace MondayAssesment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DeptId = c.Int(nullable: false, identity: true),
                        DeptName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.DeptId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        City = c.String(nullable: false),
                        Salary = c.Single(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        Departments_DeptId = c.Int(),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Departments", t => t.Departments_DeptId)
                .Index(t => t.Departments_DeptId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Departments_DeptId", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "Departments_DeptId" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
