using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class staticdemo
    {
        #region static field
        
        static int _id;
        static string _name;
        #endregion


        #region static constructors
        /// <summary>
        /// Static constructor do not allow any access modifier and it doesnot allow any parameters
        /// </summary>
        static staticdemo()
        {
            Console.WriteLine("Static Constructor");
        }

        #endregion

        #region static methods

        /// <summary>
        /// static class only allow static methods to be used
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int calculation(int x,int y)
        {
            return x * y;
        }

        #endregion

    }
}
