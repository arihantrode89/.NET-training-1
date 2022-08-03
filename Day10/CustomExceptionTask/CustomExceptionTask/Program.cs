using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionTask
{
    #region Static class and method for duplicated code
    static class Reuse
    {
        static public void WoodData(ref string SubType,ref float Rate,ref float _TotalAmount,ref int Quantity,string Type)
        {
            Console.WriteLine("Enter Wood Type:\n1.Teak\n2.Rose\n");
            if (byte.Parse(Console.ReadLine()) == 1)
            {
                SubType = Woodtype.Teak.ToString();
                Console.WriteLine($"Enter Teak wood {Type} Rate:");
                Rate = float.Parse(Console.ReadLine());
                _TotalAmount = Rate * Quantity;

            }
            else if (byte.Parse(Console.ReadLine()) == 2)
            {
                SubType = Woodtype.Rose.ToString();
                Console.WriteLine($"Enter Rose wood {Type} Rate:");
                Rate = float.Parse(Console.ReadLine());
                _TotalAmount = Rate * Quantity;

            }
        }

        static public void SteelData(ref string SubType, ref float Rate, ref float _TotalAmount, ref int Quantity, string Type)
        {
            Console.WriteLine("Enter Steel Type:\n1.Gray Steel\n2.Green Steel\n3.Brown Steel\n");
            if (byte.Parse(Console.ReadLine()) == 1)
            {
                SubType = SteelType.Gray.ToString();
                Console.WriteLine($"Enter Gray Steel wood {Type} Rate:");
                Rate = float.Parse(Console.ReadLine());
                _TotalAmount = Rate * Quantity;

            }
            else if (byte.Parse(Console.ReadLine()) == 2)
            {
                SubType = SteelType.Green.ToString();
                Console.WriteLine($"Enter Green Steel {Type} Rate:");
                Rate = float.Parse(Console.ReadLine());
                _TotalAmount = Rate * Quantity;

            }
            else if (byte.Parse(Console.ReadLine()) == 3)
            {
                SubType = SteelType.Brown.ToString();
                Console.WriteLine($"Enter Brown Steel {Type} Rate:");
                Rate = float.Parse(Console.ReadLine());
                _TotalAmount = Rate * Quantity;


            }
        }


    }

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you furniture type:\n1.Chair\n2.Cot");
            byte ch = byte.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Chair chair = new Chair();
                    chair.GetData();
                    Furniture.FurnitureType = chair;
                    chair.ShowData();
                    break;
                case 2:
                    Cot cot = new Cot();
                    cot.GetData();
                    Furniture.FurnitureType = cot;
                    cot.ShowData();
                    break ;
                default:
                    Console.WriteLine("Wrong Choice");
                    break ;
            }
        }
    }
}
