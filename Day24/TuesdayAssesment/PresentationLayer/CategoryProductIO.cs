using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using BusinessLayer;
namespace PresentationLayer
{
    internal class CategoryProductIO
    {
        CategoryProductBusinessLayer obj = new CategoryProductBusinessLayer();
        public byte Menu()
        {
            Console.WriteLine("1.Add Category\n2.Add Product Details\n3.Show Category Details\n" +
                "4.Show Product Details\n5.Show Specific Product Details\n6.Update Specific Product Price\n" +
                "7.Delete Product\n8.Exit");

            byte ch = byte.Parse(Console.ReadLine());

            return ch;
        }

        public void AddCategory()
        {
            try
            {
                Console.WriteLine("Enter Category ID");
                int Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Category Name");
                string Name = Console.ReadLine();

                Category category = new Category(Id,Name);
                obj.AddCategory(category);
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Enter Valid Input for Id and Category NAme");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void AddProduct()
        {
            try
            {
                Console.WriteLine("Enter Product ID");
                int Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Product Name");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter Product Price");
                float price = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Product Category Name");
                string CategoryName = Console.ReadLine();

                Product product = new Product(Id, Name,price);
                obj.AddProduct(product,CategoryName);
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Enter Valid Input for Id and Category NAme");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void GetCategory()
        {
            try
            {
                obj.ShowCategoryData();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void GetProduct()
        {
            try
            {
                obj.ShowProductData();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void SpecificProduct()
        {
            try
            {
                Console.WriteLine("Enter Product ID");
                int id = int.Parse(Console.ReadLine());
                obj.SpecificProductDetails(id);
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Enter valid input for product id");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void UpdateProductPrice()
        {
            try
            {
                Console.WriteLine("Enter Product Id");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Updated Price");
                float price = float.Parse(Console.ReadLine());
                bool? update = obj.UpdateProductPrice(id, price);
                if (update == true)
                {
                    Console.WriteLine("Price is Updated");
                    Console.WriteLine("".PadLeft(30, '-'));

                }
                else if (update == null)
                {
                    throw new Exception("An Error Occured");
                }

            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Enter valid input type for id and price");
                Console.WriteLine("".PadLeft(30, '-'));

            }
            catch (Exception e)
            {
                Console.WriteLine (e.Message);
            }
        }

        public void DeleteProduct()
        {
            try
            {
                Console.WriteLine("Enter Product ID");
                int id = int.Parse(Console.ReadLine());
                bool? delete = obj.DeleteProduct(id);
                if(delete == true)
                {
                    Console.WriteLine("Product Deleted Successfully");
                    Console.WriteLine("".PadLeft(30, '-'));

                }
                else if(delete == null)
                {
                    throw new Exception("An error Occured");
                }

            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Enter valid input type for id and price");
                Console.WriteLine("".PadLeft(30, '-'));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}
