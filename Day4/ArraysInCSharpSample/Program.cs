using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArraysInCSharpSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            
            // UNCOMMENT THE LINE YOU WANT TO RUN

            // p.SingleDimensionalArray();
            // p.MultiDimensionalArray();
            // p.JaggedArrays();
            // p.ArraysSample();

            // p.ArrayClassProperties();

            // p.ArrayCreateInstanceSample();

            //  p.SortAndSearchArray();

            // p.GetSetArrayValues();

            // p.ReverseArray();

            // p.ClearArray();

            // p.CopyArray();

            p.CloneArray();

            Console.ReadKey();
        }

        #region CloneArray
        private void CloneArray()
        {
           
            
            // Create an array and add 5 items to it
            Array stringArray = Array.CreateInstance(typeof(String), 5);
            
            stringArray.SetValue("Ramesh", 0);
            stringArray.SetValue("Rajesh", 1);
            stringArray.SetValue("Neelesh", 2);
            stringArray.SetValue("Venkatesh", 3);
            stringArray.SetValue("Kamalesh", 4);

            Console.WriteLine("Original Array");
            Console.WriteLine("---------------------");
            foreach (string str in stringArray)
            {
                Console.WriteLine(str);
            }

            // Clone 
            string[] clonedArray = (string[])stringArray.Clone();
            Console.WriteLine("Cloned Array");
            Console.WriteLine("---------------------");
            foreach (string str in clonedArray)
            {
                Console.WriteLine(str);
            }


        }
        #endregion 

        #region CopyArray
        private void CopyArray()
        {
        // Creates and initializes a new Array of type Int32.
        Array oddArray = Array.CreateInstance(Type.GetType("System.Int32"), 5);
        oddArray.SetValue(1, 0);
        oddArray.SetValue(3, 1);
        oddArray.SetValue(5, 2);
        oddArray.SetValue(7, 3);
        oddArray.SetValue(9, 4);
        // Creates and initializes a new Array of type Object.
        Array objArray = Array.CreateInstance(Type.GetType("System.Object"), 5);
        Array.Copy(oddArray, oddArray.GetLowerBound(0), objArray, objArray.GetLowerBound(0), 4);
        int items1 = objArray.GetUpperBound(0);
        for (int i = 0; i < items1; i++)
            Console.WriteLine(objArray.GetValue(i).ToString()); 

        }
        #endregion 

        #region ClearArray
        private void ClearArray()
        {
            Array stringArray = Array.CreateInstance(typeof(String), 5);
            stringArray.SetValue("Rajesh", 0);
            stringArray.SetValue("Ramesh", 1);
            stringArray.SetValue("Jithesh", 2);
            stringArray.SetValue("Kamalesh", 3);
            stringArray.SetValue("Venktesh", 4);
            Console.WriteLine("Original Array");
            Console.WriteLine("---------------------");
            foreach (string str in stringArray)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine();
            Console.WriteLine("Clear Items");
            Console.WriteLine("---------------------");
            Array.Clear(stringArray, 1, 2);

            foreach (string str in stringArray)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine(stringArray.GetLength(0).ToString());
            Console.WriteLine(stringArray.GetLowerBound(0).ToString());
            Console.WriteLine(stringArray.GetUpperBound(0).ToString());  

        }
        #endregion 
        
        #region ReverseArray
        private void ReverseArray()
        {
        // Create an array and add 5 items to it
        Array stringArray = Array.CreateInstance(typeof(String), 5);
        stringArray.SetValue("Rajesh", 0);
        stringArray.SetValue("Ramesh", 1);
        stringArray.SetValue("Jithesh", 2);
        stringArray.SetValue("Kamalesh", 3);
        stringArray.SetValue("Venktesh", 4);
            
        Console.WriteLine("Original Array");
        Console.WriteLine("---------------------");
        foreach (string str in stringArray)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine();
        Console.WriteLine("Reversed Array");
        Console.WriteLine("---------------------");
        Array.Reverse(stringArray);
        //  Array.Sort(stringArray, 2, 3);
        foreach (string str in stringArray)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine();
        Console.WriteLine("Double Reversed Array");
        Console.WriteLine("---------------------");
        Array.Reverse(stringArray);
        //  Array.Sort(stringArray, 2, 3);
        foreach (string str in stringArray)
        {
            Console.WriteLine(str);
        }
        }
        #endregion

        #region GetSetArrayValues
        private void GetSetArrayValues()
        {
            Array names = Array.CreateInstance(typeof(String), 2, 4);
            names.SetValue("Rosy", 0, 0);
            names.SetValue("Amy", 0, 1);
            names.SetValue("Peter", 0, 2);
            names.SetValue("Albert", 0, 3);
            names.SetValue("Mel", 1, 0);
            names.SetValue("Mongee", 1, 1);
            names.SetValue("Luma", 1, 2);
            names.SetValue("Lara", 1, 3);
            int items1 = names.GetLength(0);
            int items2 = names.GetLength(1);
            for (int i = 0; i < items1; i++)
                for (int j = 0; j < items2; j++)
                    Console.WriteLine(i.ToString() + "," + j.ToString() + ": " + names.GetValue(i, j)); 

        }
        #endregion
        
        #region Sort and Search Array
        private void SortAndSearchArray()
        {
            // Create an array and add 5 items to it
            Array stringArray = Array.CreateInstance(typeof(String), 5);
            stringArray.SetValue("Rajesh", 0);
            stringArray.SetValue("Ramesh", 1);
            stringArray.SetValue("Jithesh", 2);
            stringArray.SetValue("Kamalesh", 3);
            stringArray.SetValue("Venkatesh", 4);

            // Find an item
            object name = "Neel";
            int nameIndex = Array.BinarySearch(stringArray, name);
            if (nameIndex >= 0)
                Console.WriteLine("Item was at " + nameIndex.ToString() + "th position");
            else
                Console.WriteLine("Item not found");

            Console.WriteLine();

            Console.WriteLine("Original Array");
            Console.WriteLine("---------------------");
            foreach (string str in stringArray)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine();
            Console.WriteLine("Sorted Array");
            Console.WriteLine("---------------------");
            Array.Sort(stringArray);
          //  Array.Sort(stringArray, 2, 3);
            foreach (string str in stringArray)
            {
                Console.WriteLine(str);
            }            
        }
        #endregion
        
        #region ArrayCreateInstanceSample
        private void ArrayCreateInstanceSample()
        {
            Array stringArray = Array.CreateInstance(typeof(String), 3);
            stringArray.SetValue("Rajesh", 0);
            stringArray.SetValue("Raj Kumar", 1);
            stringArray.SetValue("Neel Kumar", 2);

            foreach (string str in stringArray)
            {
                Console.WriteLine(str);
            }

            Array intArray3D = Array.CreateInstance(typeof(Int32), 2, 3, 4);
            for (int i = intArray3D.GetLowerBound(0); i <= intArray3D.GetUpperBound(0); i++)
                for (int j = intArray3D.GetLowerBound(1); j <= intArray3D.GetUpperBound(1); j++)
                    for (int k = intArray3D.GetLowerBound(2); k <= intArray3D.GetUpperBound(2); k++)
                    {
                        intArray3D.SetValue((i * 100) + (j * 10) + k, i, j, k);
                    }

            foreach (int ival in intArray3D)
            {
                Console.WriteLine(ival);
            }
        }
        #endregion 

        #region Array Class Properties
        private void ArrayClassProperties()
        {            
            int[] intArray = new int[3] {0, 1, 2};
            if(intArray.IsFixedSize)
            {
                Console.WriteLine("Array is fixed size");
                Console.WriteLine("Size :" + intArray.Length.ToString());
                Console.WriteLine("Rank :" + intArray.Rank.ToString());
            }
           
        }

        #endregion 

        #region ArraysSample
        private void ArraysSample()
        {
            Console.WriteLine("Single Dimension Array Sample");
            // Single dim array
            string[] strArray = new string[] { "Roopesh", "Mike Gold", "Raj singh", "Praveen Kumar", "Dinesh Kumar" };
            // Read array items using foreach loop
            foreach (string str in strArray)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Multi-Dimension Array Sample");
            string[,] string2DArray = new string[2, 2] { { "Rosy", "Amy" }, { "Peter", "Albert" } };
            foreach (string str in string2DArray)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Jagged Array Sample");
            int[][] intJaggedArray3 = 
            {
                new int[] {2,12},
                new int[] {14, 14, 24, 34},
                new int[] {6, 16, 26, 36, 46, 56}
            };
            // Loop through all itesm of a jagged array
            for (int i = 0; i < intJaggedArray3.Length; i++)
            {
                Console.Write("Element({0}): ", i);
                for (int j = 0; j < intJaggedArray3[i].Length; j++)
                {
                    Console.Write("{0}{1}", intJaggedArray3[i][j], j == (intJaggedArray3[i].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------");

        }
        #endregion

        #region JaggedArrays
        private void JaggedArrays()
        {
            // Declaring jagged arrays
            int[][] intJaggedArray = new int[3][];
            string[][] stringJaggedArray = new string[2][];

            // Initializing jagged arrays
            intJaggedArray[0] = new int[2] { 2, 12 };
            intJaggedArray[1] = new int[4] { 4, 14, 24, 34 };
            intJaggedArray[2] = new int[6] { 6, 16, 26, 36, 46, 56 };

            int[][] intJaggedArray3 = 
            {
                new int[] {2,12},
                new int[] {14, 14, 24, 34},
                new int[] {6, 16, 26, 36, 46, 56}
            };


            // Accessing jagged arrays
            Console.Write(intJaggedArray3[0][0]);
            Console.WriteLine();
            Console.WriteLine(intJaggedArray3[2][5]);
            Console.WriteLine();

            // Loop through all itesm of a jagged array
            for (int i = 0; i < intJaggedArray3.Length; i++)
            {
                System.Console.Write("Element({0}): ", i);
                for (int j = 0; j < intJaggedArray3[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", intJaggedArray3[i][j], j == (intJaggedArray3[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }

        }
        #endregion

        #region SingleDimensionalArray
        private void SingleDimensionalArray()
        {
            int[] intArray;
            intArray = new int[100];
            double[] doubleArray = new double[5];
            char[] charArray = new char[5];
            bool[] boolArray = new bool[2];
            string[] stringArray = new string[10];

            // Initialize a fixed array 
            // int[] staticIntArray = new int[3] {1, 3, 5};

            // Initialize a fixed array one item at a time
            int[] staticIntArray = new int[3];

            staticIntArray[0] = 1;
            staticIntArray[1] = 3;
            staticIntArray[2] = 5;

            // Read array items one by one 
            Console.WriteLine(staticIntArray[0]);
            Console.WriteLine(staticIntArray[1]);
            Console.WriteLine(staticIntArray[2]);

            // Initialize a dynamic array items during declaration 
            string[] strArray = new string[] { "Lakshman", "Mike Gold", "Raj singh", "Praveen Kumar", "Dinesh Kumar" };

            // Read array items using foreach loop
            foreach (string str in strArray)
            {
                Console.WriteLine(str);
            }
        }
        #endregion

        #region MultiDimensionalArray
        private void MultiDimensionalArray()
        {
            Console.WriteLine("Multidimensional arrays");
            //string[,] mutliDimStringArray;

            // int[,] numbers = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            int[,] numbers = new int[3, 2];
            numbers[0, 0] = 1;
            numbers[1, 0] = 2;
            numbers[2, 0] = 3;
            numbers[0, 1] = 4;
            numbers[1, 1] = 5;
            numbers[2, 1] = 6;

            string[,] names = new string[2, 2] { { "Rosy", "Amy" }, { "Peter", "Albert" } };

            //int[,] numbers = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            //string[,] names = { { "Rosy", "Amy" }, { "Peter", "Albert" } };

            Console.WriteLine(numbers[0, 0]);
            Console.WriteLine(numbers[1, 0]);
            Console.WriteLine(numbers[2, 0]);
            Console.WriteLine(numbers[0, 1]);
            Console.WriteLine(numbers[1, 1]);
            Console.WriteLine(numbers[2, 1]);
        }
        #endregion
                       
    }
}
