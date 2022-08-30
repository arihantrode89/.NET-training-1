namespace TaskCodeApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StoredProc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false),
                        Price = c.Single(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateStoredProcedure(
                "dbo.InsertCategory",
                p => new
                    {
                        CategoryName = p.String(),
                    },
                body:
                    @"INSERT [dbo].[Categories]([CategoryName])
                      VALUES (@CategoryName)
                      
                      DECLARE @CategoryId int
                      SELECT @CategoryId = [CategoryId]
                      FROM [dbo].[Categories]
                      WHERE @@ROWCOUNT > 0 AND [CategoryId] = scope_identity()
                      
                      SELECT t0.[CategoryId]
                      FROM [dbo].[Categories] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[CategoryId] = @CategoryId"
            );
            
            CreateStoredProcedure(
                "dbo.UpdateCategory",
                p => new
                    {
                        CategoryId = p.Int(),
                        CategoryName = p.String(),
                    },
                body:
                    @"UPDATE [dbo].[Categories]
                      SET [CategoryName] = @CategoryName
                      WHERE ([CategoryId] = @CategoryId)"
            );
            
            CreateStoredProcedure(
                "dbo.DeleteCategory",
                p => new
                    {
                        CategoryId = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Categories]
                      WHERE ([CategoryId] = @CategoryId)"
            );
            
            CreateStoredProcedure(
                "dbo.InsertProduct",
                p => new
                    {
                        ProductName = p.String(),
                        Price = p.Single(),
                        CategoryId = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Products]([ProductName], [Price], [CategoryId])
                      VALUES (@ProductName, @Price, @CategoryId)
                      
                      DECLARE @ProductId int
                      SELECT @ProductId = [ProductId]
                      FROM [dbo].[Products]
                      WHERE @@ROWCOUNT > 0 AND [ProductId] = scope_identity()
                      
                      SELECT t0.[ProductId]
                      FROM [dbo].[Products] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[ProductId] = @ProductId"
            );
            
            CreateStoredProcedure(
                "dbo.UpdateProduct",
                p => new
                    {
                        ProductId = p.Int(),
                        ProductName = p.String(),
                        Price = p.Single(),
                        CategoryId = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Products]
                      SET [ProductName] = @ProductName, [Price] = @Price, [CategoryId] = @CategoryId
                      WHERE ([ProductId] = @ProductId)"
            );
            
            CreateStoredProcedure(
                "dbo.DeleteProduct",
                p => new
                    {
                        ProductId = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Products]
                      WHERE ([ProductId] = @ProductId)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.DeleteProduct");
            DropStoredProcedure("dbo.UpdateProduct");
            DropStoredProcedure("dbo.InsertProduct");
            DropStoredProcedure("dbo.DeleteCategory");
            DropStoredProcedure("dbo.UpdateCategory");
            DropStoredProcedure("dbo.InsertCategory");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
