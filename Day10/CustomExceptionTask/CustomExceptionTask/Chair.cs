using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionTask
{

    #region Enum's
    enum Woodtype
    {
        Teak,Rose
    }

    enum SteelType
    {
        Gray,Green,Brown
    }

    enum PlasticColor
    {
        Green,Red,Blue,White

    }

    enum EPurpose
    {
        Home=1,Office
    }

    enum ChairType
    {
        Wood,Steel,Plastic
    }

    #endregion

    internal class Chair:Furniture
    {
        #region Chair Data fields

        public string _purpose,_type,_color,_subtype;
        public float _rate;

        #endregion

        #region Properties
        public string Purpose { get { return _purpose; } set { _purpose = value; } }
        public string Type { get { return _type; } set { _type = value; } }
        public string Color { get { return _color; } set { _color = value; } }
        public string SubType { get { return _subtype; } set { _subtype = value; } }
        public float Rate { get { return _rate; } set { _rate = value; } }

        #endregion

        #region Methods
        public override void GetData()
        {
            base.GetData();
            Console.WriteLine("Enter the purpose of buying chair:\n1.Home\n2.Office\n");
            try
            {
                if (byte.Parse(Console.ReadLine()) == 1)
                {
                    Purpose = EPurpose.Home.ToString();
                }
                else if (byte.Parse(Console.ReadLine()) == 2)
                {
                    Purpose = EPurpose.Office.ToString();
                }
                else
                {
                    throw new ExceptionClass();
                }
            }
            catch(ExceptionClass e)
            {
                e.WrongChoice();
            }

            try
            {
                Console.WriteLine("Enter Type of Chair:\n1.Wood\n2.Steel\n3.Plastic\n");
                if (byte.Parse(Console.ReadLine()) == 1)
                {
                    Type = ChairType.Wood.ToString();
                    Reuse.WoodData(ref _subtype, ref _rate, ref _TotalAmount,ref _qty,"Chair");

                }
                else if (byte.Parse(Console.ReadLine()) == 2)
                {
                    Type = ChairType.Steel.ToString();
                    Reuse.SteelData(ref _subtype, ref _rate, ref _TotalAmount, ref _qty, "Chair");

                }
                else if (byte.Parse(Console.ReadLine()) == 3)
                {
                    Type = ChairType.Plastic.ToString();

                    Console.WriteLine("Enter Plastic Color :\n1.Green\n2.Red\n3.Blue\n4.White");
                    if (byte.Parse(Console.ReadLine()) == 1)
                    {
                        Color = PlasticColor.Green.ToString();
                        Console.WriteLine("Enter Green Plastic chair Rate:");
                        Rate = float.Parse(Console.ReadLine());
                        _TotalAmount = Rate * Quantity;

                    }
                    else if (byte.Parse(Console.ReadLine()) == 2)
                    {
                        SubType = PlasticColor.Red.ToString();
                        Console.WriteLine("Enter Red Plastic chair Rate:");
                        Rate = float.Parse(Console.ReadLine());
                        _TotalAmount = Rate * Quantity;

                    }
                    else if (byte.Parse(Console.ReadLine()) == 3)
                    {
                        SubType = PlasticColor.Blue.ToString();
                        Console.WriteLine("Enter Blue Plastic chair Rate:");
                        Rate = float.Parse(Console.ReadLine());
                        _TotalAmount = Rate * Quantity;


                    }
                    else if (byte.Parse(Console.ReadLine()) == 4)
                    {
                        SubType = PlasticColor.White.ToString();
                        Console.WriteLine("Enter White Plastic Chair Rate:");
                        Rate = float.Parse(Console.ReadLine());
                        _TotalAmount = Rate * Quantity;


                    }
                }
                else
                {
                    throw new ExceptionClass();
                }
            }
            catch(ExceptionClass e)
            {
                e.WrongChoice();
            }

        }
        public override void ShowData()
        {
            base.ShowData();
            if(Type == ChairType.Wood.ToString() || Type == ChairType.Steel.ToString())
            {
                Console.WriteLine($"Chair Type:{Type}\nPurpose:{Purpose}\nSub Type:{SubType}\nRate:{Rate}");
                Console.WriteLine("".PadLeft(30, '-'));
            }
            else if (Type == ChairType.Plastic.ToString())
            {
                Console.WriteLine($"Chair Type:{Type}\nPurpose:{Purpose}\nPlastic Color:{Color}\nRate:{Rate}");
                Console.WriteLine("".PadLeft(30, '-'));
            }

        }

        #endregion

    }
}
