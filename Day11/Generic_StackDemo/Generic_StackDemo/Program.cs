﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_StackDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region Initialization and Push Method
            Stack<string> stack = new Stack<string>();

            stack.Push("Rode");
            stack.Push("Manoj");
            stack.Push("Arihant");
            stack.Push("Nagpur");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("".PadLeft(30, '-'));
            #endregion

            #region Peek Method
            Console.WriteLine($"Top element of stack using Peek func is:{stack.Peek()}");

            Console.WriteLine("".PadLeft(30, '-'));
            #endregion

            #region Pop Method
            stack.Pop();
            Console.WriteLine("After popping one element:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("".PadLeft(30, '-'));
            #endregion

            #region Contains Method
            Console.WriteLine("Using Contains(Arihant): " + stack.Contains("Arihant"));

            #endregion
        }
    }
}
