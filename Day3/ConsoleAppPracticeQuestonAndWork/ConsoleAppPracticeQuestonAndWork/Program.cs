using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPracticeQuestonAndWork
{
    internal class Program
    {
        static bool pallindrome(string s)
        {
            String str = "";
            s = s.ToLower();
            int len = s.Length;
            for (int i = len - 1; i >= 0; i--)
            {
                str += s[i];
            }

            //foreach (char i in s.Reverse())
            //{
            //    str += i;
            //}

            return s == str;
        }

        static bool Armstrong(int num)
        {
            int sum = 0;
            string str = Convert.ToString(num);
            //for(int i=0;i<str.Length;i++)
            //{
            //    int amod = int.Parse(str) % 10;
            //    sum += (amod * amod * amod);

            //}
            int tmp = num;
            while(tmp>0)
            {
                int amod = tmp % 10;
                sum += (amod * amod * amod);
                tmp = tmp / 10;
            }
            
            return num == sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(pallindrome("121")) ;
            Console.WriteLine(Armstrong(5));


        }
    }
}
