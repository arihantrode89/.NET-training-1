﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query_Syntax_linqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3,4,5,6,7,8,9,10 };

            var result = from num in list where num%2==0 select num;

            foreach(int num in result)
            {
                Console.WriteLine(num);
            }
        }
    }
}
