using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsDemo
{
    internal class Program
    {

        /// <summary>
        /// By using param we can send parameters like array and object[] is used for passing multiple data type values
        /// </summary>
        /// <param name="arr"></param>
        public static void Method(params object[] arr)
        { 
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }


        /// <summary>
        /// int[] is used for passing only integer.we need to mention specific type for passing that type of array
        /// </summary>
        /// <param name="arr"></param>
        public static void Method1(params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        
        public static void NamedParam(String firstname,String lastname)
        {
            Console.WriteLine($"{firstname}_{lastname}");
        }
        
        public static void DefaultParameter(string name,int id=12,string role="Software Engineer",string Blood = "A+ve")
        {
            Console.WriteLine($"{name}-{id}-{role}-{Blood}");
        }
        
        public static dynamic DynamicParameter(dynamic a)
        {
            a *= a;
            return a;

        }
        
        static void Main(string[] args)
        {
            Method("Arihant", 20, 07, "Rode");
            Console.WriteLine("".PadLeft(30, '-'));
            Method1( 20, 07, 2022);
            Console.WriteLine("".PadLeft(30, '-'));


            NamedParam("Arihant", "Rode");
            NamedParam(firstname: "Arihant", lastname: "Rode");//This way we can use named parameter

            Console.WriteLine("".PadLeft(30, '-'));

            DefaultParameter("arihant");
            DefaultParameter("arihant", 7070);
            DefaultParameter("arihant",role:"Trainee");
            DefaultParameter("arihant", 7070,"trainee","O-ve");

            Console.WriteLine("".PadLeft(30, '-'));

            Console.WriteLine(DynamicParameter(12));



        }
    }
}
