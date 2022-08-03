using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[]{1,2,3,4,5,6};
            int[] arrcopy = new int[6];
            int[] arr1 = new int[] {6,2,4,8,1,7,5 };
            //for (int i=0;i<arr.Length;i++)
            //{
            //    Console.WriteLine(arr[i]);

            //}
            //Console.WriteLine("".PadRight());
            for (int i = arr.Length-1; i >=0; i--)
            {
                Console.WriteLine(arr[i]);

            }

            Console.WriteLine(" ".PadLeft(26, '-'));
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

            }
            Console.WriteLine("Sum is {0} ",sum);

            Console.WriteLine(" ".PadLeft(26, '-'));


            int count = 0;
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=0;j<arr.Length;j++)
                {
                    if(arr[i] == arr1[j])
                    {
                        count += 1;
                    }
                }
            }
            Console.WriteLine("Duplicate Count is  {0}", count);

            Console.WriteLine(" ".PadLeft(26, '-'));

            for (int i=0;i<arr.Length;i++)
            {
                arrcopy[i] = arr[i];
            }

            for (int i =0; i<arrcopy.Length; i++)
            {
                Console.WriteLine(arrcopy[i]);

            }

            Console.WriteLine(" ".PadLeft(26,'-'));
            int temp = 0;
            //for(int i=0;i<arr1.Length-1;i++)
            //{
            //    if (arr1[i] > arr1[i+1])
            //    {
            //        temp = arr1[i];
            //        arr1[i] = arr1[i + 1];
            //        arr1[i + 1] = temp;
            //    }
            //}

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine(arr1[i]);

            //}

            foreach(int a in arr)
            {
                Console.WriteLine(a);
            }



        }
    }
}
