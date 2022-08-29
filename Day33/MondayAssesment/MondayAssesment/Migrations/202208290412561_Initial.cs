namespace MondayAssesment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "Departments_DeptId", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "Departments_DeptId" });
            DropColumn("dbo.Employees", "DepartmentId");
            RenameColumn(table: "dbo.Employees", name: "Departments_DeptId", newName: "DepartmentId");
            AlterColumn("dbo.Employees", "DepartmentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "DepartmentId");
            AddForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments", "DeptId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "DepartmentId" });
            AlterColumn("dbo.Employees", "DepartmentId", c => c.Int());
            RenameColumn(table: "dbo.Employees", name: "DepartmentId", newName: "Departments_DeptId");
            AddColumn("dbo.Employees", "DepartmentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "Departments_DeptId");
            AddForeignKey("dbo.Employees", "Departments_DeptId", "dbo.Departments", "DeptId");
        }
    }
}
