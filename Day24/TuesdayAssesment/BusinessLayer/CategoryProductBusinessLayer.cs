using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Entity;

namespace BusinessLayer
{
    public class CategoryProductBusinessLayer:ICategoryProduct
    {
        CategoryProductDataAccessLogic obj = new CategoryProductDataAccessLogic();

        public void AddCategory(Category ctg)
        {
            try
            {
                obj.InsertIntoCategoryTable(ctg);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void AddProduct(Product ptd,string CategoryName)
        {
            try
            {
                obj.InsertIntoProductTable(ptd,CategoryName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void ShowCategoryData()
        {
            try
            {
                obj.GetCategoryData();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void ShowProductData()
        {
            try
            {
                obj.GetProductData();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void SpecificProductDetails(int ProductId)
        {
            try
            {
                obj.RetrieveSpecificProductData(ProductId);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public bool? UpdateProductPrice(int ProductId,float Price)
        {
            try
            {
                return obj.UpdateProductPriceValue(ProductId,Price);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public bool? DeleteProduct(int ProductId)
        {
            try
            {
                return obj.DeleteProductfromTable(ProductId);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
