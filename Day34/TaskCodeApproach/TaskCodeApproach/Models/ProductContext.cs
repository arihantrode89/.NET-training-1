using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using TaskCodeApproach.ViewModel;

namespace TaskCodeApproach.Models
{
    public class ProductContext:DbContext
    {
        public ProductContext() : base("ProductContext")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().MapToStoredProcedures
                 (
                     s => s.Insert(i => i.HasName("InsertProduct", "dbo"))
                     .Update(u => u.HasName("UpdateProduct", "dbo"))
                     .Delete(d => d.HasName("DeleteProduct", "dbo"))
                );

            modelBuilder.Entity<Category>().MapToStoredProcedures
                 (
                     s => s.Insert(i => i.HasName("InsertCategory", "dbo"))
                     .Update(u => u.HasName("UpdateCategory", "dbo"))
                     .Delete(d => d.HasName("DeleteCategory", "dbo"))
                );
        }

        public IEnumerable<ProductCategory> Sp_GetProducts()
        {
            var data = ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<ProductCategory>("GetProducts");
            return data;
        }


    }
}