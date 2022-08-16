using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    internal class CategoryProductManagement
    {
        static void Main(string[] args)
        {
            CategoryProductIO categoryProduct = new CategoryProductIO();
            Boolean flg = true;
            do
            {
                byte ch = categoryProduct.Menu();
                switch (ch)
                {
                    case 1:
                        categoryProduct.AddCategory();
                        Console.WriteLine("".PadLeft(30, '-'));
                        flg = true;
                        break;
                    case 2:
                        categoryProduct.AddProduct();
                        Console.WriteLine("".PadLeft(30, '-'));
                        flg = true;
                        break;
                    case 3:
                        categoryProduct.GetCategory();
                        Console.WriteLine("".PadLeft(30, '-'));
                        flg = true;
                        break;
                    case 4:
                        categoryProduct.GetProduct();

                        Console.WriteLine("".PadLeft(30, '-'));

                        flg = true;
                        break;
                    case 5:
                        categoryProduct.SpecificProduct();

                        Console.WriteLine("".PadLeft(30, '-'));

                        flg = true;
                        break;
                    case 6:
                        categoryProduct.UpdateProductPrice();

                        flg = true;
                        break;
                    case 7:
                        categoryProduct.DeleteProduct();

                        flg = true;
                        break;

                    case 8:
                        flg = false;
                        break;
                    default:
                        Console.WriteLine("Wrong Choice..Please Enter Again");
                        flg = true;
                        break;

                }

            } while (flg);
        }
    }
}
