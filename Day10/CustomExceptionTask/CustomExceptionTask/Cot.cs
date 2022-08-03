using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionTask
{
    #region Enum
    enum CotCapacity
    {
        Single,Double
    }

    #endregion
    internal class Cot:Furniture
    {
        #region Cot Data fields

        string _type,_subtype,_capacity;
        float _rate;

        #endregion

        #region Properties
        public string Type { get { return _type; } set { _type = value; } }
        public string SubType { get { return _subtype; } set { _subtype = value; } }
        public string Capacity { get { return _capacity; } set { _capacity = value; } }
        public float Rate { get { return _rate; } set { _rate = value; } }

        #endregion

        #region Methods
        public override void GetData()
        {
            base.GetData();
            try
            {
                Console.WriteLine("Enter Capacity of Cot");
                if (byte.Parse(Console.ReadLine()) == 1)
                {
                    Capacity = CotCapacity.Single.ToString();
                }
                else if (byte.Parse(Console.ReadLine()) == 2)
                {
                    Capacity = CotCapacity.Double.ToString();

                }

                Console.WriteLine("Enter Type of Cot\n1.Wood\n2.Steel\n");
                if (byte.Parse(Console.ReadLine()) == 1)
                {
                    Type = ChairType.Wood.ToString();
                    Reuse.WoodData(ref _subtype, ref _rate,ref _TotalAmount, ref _qty, "Cot");

                }
                else if (byte.Parse(Console.ReadLine()) == 2)
                {
                    Type = ChairType.Steel.ToString();
                    Reuse.SteelData(ref _subtype, ref _rate, ref _TotalAmount, ref _qty, "Cot");
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
            if (Type == ChairType.Wood.ToString() || Type == ChairType.Steel.ToString())
            {
                Console.WriteLine($"Cot Type:{Type}\nCapacity:{Capacity}\nSub Type:{SubType}\nRate:{Rate}");
                Console.WriteLine("".PadLeft(30, '-'));
            }
            
        }

        #endregion
    }
}
