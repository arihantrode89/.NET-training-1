using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace BusinessLayer
{
    internal interface ICategoryProduct
    {
        void AddCategory(Category ctg);
        void AddProduct(Product ptd, string CategoryName);
        void ShowCategoryData();
        void ShowProductData(); 
        void SpecificProductDetails(int ProductId);
        bool? UpdateProductPrice(int ProductId, float Price);
        bool? DeleteProduct(int ProductId);
    }
}
