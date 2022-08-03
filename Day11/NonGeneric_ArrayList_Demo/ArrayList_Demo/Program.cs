using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Initialization and Add method
            ArrayList obj = new ArrayList();
            obj.Add(1);
            obj.Add("Arihant");
            obj.Add("Rode");
            obj.Add("July");
            foreach (var i in obj)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("".PadLeft(30, '-'));
            #endregion

            #region Insert Method and Count Property
            Console.WriteLine("Before Insertion:" + " " + obj.Count);
            obj.Insert(2, "Manoj");
            Console.WriteLine("After Insertion:" + " " + obj.Count);

            Console.WriteLine("".PadLeft(30, '-'));

            foreach (var i in obj)
            {
                Console.WriteLine(i + " ");
            }

            Console.WriteLine("".PadLeft(30, '-'));

            #endregion

            #region Range Method
            Console.WriteLine("Specific Range Array List:");
            var SpecificRange = obj.GetRange(0, 2);
            foreach (var item in SpecificRange)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("".PadLeft(30, '-'));
            #endregion

            #region Sort Method
            Console.WriteLine("After Sorting:");
            obj[0] = obj[0].ToString();
            obj.Sort();//It will give invalid operation error because of diffrent data type.we can convert data type then
            foreach (var i in obj)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("".PadLeft(30, '-'));
            #endregion

            #region Reverse Method
            obj.Reverse();
            Console.WriteLine("reversed arraylist is:");
            foreach (var i in obj)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("".PadLeft(30, '-'));

            #endregion

            #region Remove and RemoveAt Method
            //Console.WriteLine("After using Remove(Arihant) Method:");
            //obj.Remove("Arihant");
            //foreach (var i in obj)
            //{
            //    Console.WriteLine(i + " ");
            //}

            //Console.WriteLine("".PadLeft(30, '-'));


            //obj.RemoveAt(0);
            //Console.WriteLine("After using Remove(0) Method:");
            //foreach (var i in obj)
            //{
            //    Console.WriteLine(i + " ");
            //}

            Console.WriteLine("".PadLeft(30, '-'));

            #endregion

            #region BinarySearch Method
            ArrayList obj1 = new ArrayList();
            obj1.Add(2);
            obj1.Add(3);
            obj1.Add(1);
            obj1.Add(0);
            Console.WriteLine($"After using BinarySearch(2): {obj1.BinarySearch(2)}");

            Console.WriteLine("".PadLeft(30,'-'));
            #endregion

            #region Contains Method
            Console.WriteLine($"After using Contains(Arihant):{obj.Contains("Arihant")}");

            Console.WriteLine("".PadLeft(30, '-'));
            #endregion
        }
    }
}
