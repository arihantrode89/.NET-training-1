using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo
{

    
    internal class LaptopApp
    {
        static Laptop[] laptopArray = new Laptop[0];

        static void DisplayMenu()
        {
            Console.WriteLine("1.Add Elements\n2.Display Elements\n3.Exit\n");


        }

        static Boolean SelectionOperation(byte ch)
        {
            switch(ch)
            {
                case 1:
                    laptopArray = DynamicArray(laptopArray);
                    laptopArray = AddElements(laptopArray);
                    return true;

                case 2:
                    DisplayData(laptopArray);
                    return true;

                case 3:
                    return false;

                default:
                    Console.WriteLine("Wrong Option!...Choose correct one");
                    return true;
            }
        }

        static Laptop[] DynamicArray(Laptop[] arr)
        {
            Laptop[] temp = new Laptop[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            return temp;
        }

        static Laptop[] AddElements(Laptop[] arr)
        {
            Console.WriteLine("Enter the elements");
            for (int i = arr.Length - 1; i < arr.Length; i++)
            {
                arr[i] = new Laptop();
                Console.WriteLine("Enter laptop Name");
                string name = Console.ReadLine();
                arr[i].SetLaptopName(name);

                Console.WriteLine("Enter Model Name");
                int model = int.Parse(Console.ReadLine());
                arr[i].SetModelNumber(model);

                Console.WriteLine("Enter ram");
                byte ram = byte.Parse(Console.ReadLine());
                arr[i].SetRam(ram);

                Console.WriteLine("Enter amount");
                float amount = float.Parse(Console.ReadLine());
                arr[i].SetAmount(amount);
            }
            return arr;
        }

        static void DisplayData(Laptop[] arr)
        {
            foreach(Laptop item in arr)
            {
                Console.WriteLine("Name: {0}\n" +
                    "Model Number: {1}\n" +
                    "Ram: {2}\n" +
                    "Amount: {3}\n", item.GetLaptopName(), item.GetModelNumber(), item.GetRam(), item.GetAmount());
            }
        }
        
        
        static void Main(string[] args)
        {
            Boolean flag = true;
            do
            {
                DisplayMenu();
                Console.WriteLine("Enter Choice");
                byte ch = byte.Parse(Console.ReadLine());
                flag = SelectionOperation(ch);
            } while (flag);
            
        }
    }
}
