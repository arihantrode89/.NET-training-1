using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPracticeQuestion
{
    internal class Program
    {

        bool pallindrome(string s)
        {
            String str = "";
            int len = s.Length;
            for(int i=len-1;i>=0;i--)
            {
                str += s[i];
            }
            
            //foreach (char i in s.Reverse())
            //{
            //    str += i;
            //}

            return s == str;
        }

        int Fact(int a)
        {
            if (a == 0)
            {
                return 1;
            }
            return a * Fact(a - 1);
        }

        static void Fibo(int n)
        {
            int a=0;
            int b = 1;
            if (n < 1)
            {
                return;
            }
            Console.WriteLine(a + " ");
            for(int i=1;i<n;i++)
            {
                Console.WriteLine(b + " ");
                int c = a + b;
                a = b;
                b = c;
            }

        }

        public readonly string a = "Rode";
        static void Main(string[] args)
        {
            Program S = new Program();
            //Console.WriteLine(S.Fact(5));
            //Fibo(10);

            Console.WriteLine(S.pallindrome("nayan"));

            //Console.WriteLine(char.Parse("5"));
            double d = 100.25;
            int i = (int)d;

            // for const
            //const string s = "Rode";
            //s = "Arihant";


            //string s1 = "Rode";
            //s1 = "Arihant";

            //Console.WriteLine(("5").PadRight(24, '-'));
            //Console.WriteLine("{0,16:P3}",5);
            //Console.WriteLine(("5").PadRight(24, '-'));
            //int i1 = 1;
            //do
            //{
            //    i1++;
            //    Console.WriteLine(i1);
            //    //i1++;

            //} while (i1 <= 10);

            //Console.WriteLine("Num: ");
            //int num = int.Parse(Console.ReadLine());
            //int num1 = int.Parse(Console.ReadLine());
            //switch (num)
            //{
            //    case 1:
            //        Console.WriteLine("It is " + 1);
            //        break;
            //    case 2:
            //        Console.WriteLine("It is " + 2);
            //        break;
            //    default:
            //        Console.WriteLine("THis is default");
            //        break;
            //}

        }
    }
}
