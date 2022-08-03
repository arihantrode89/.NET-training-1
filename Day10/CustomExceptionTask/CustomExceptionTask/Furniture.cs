using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionTask
{
    internal class Furniture
    {
        #region Data fields

        public int _Orderid,_qty;
        string _Orderdate, _PaymentMode;
        public float _TotalAmount;
        public static dynamic FurnitureType;

        #endregion

        #region Properties
        public int OrderId { get { return _Orderid; } set { _Orderid = value; } }
        public int Quantity { get { return _qty; } set { _qty = value; } }
        public string OrderDate { get { return _Orderdate; } set { _Orderdate = value; } }
        
        public string PaymentMode { get { return _PaymentMode; } set { _PaymentMode = value; } }

        public float TotalAmount { get { return _TotalAmount; } set { _TotalAmount = value; } }

        #endregion

        #region Methods
        public virtual void GetData()
        {
            Console.WriteLine("Enter Furniture Details");
            Console.WriteLine("".PadLeft(30, '-'));
            Console.WriteLine("Enter Order Id");
            OrderId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Quantity");
            Quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Order Date in dd-mm-yyyy format");
            OrderDate = Console.ReadLine();
            Console.WriteLine("Enter Payment Mode");
            PaymentMode = Console.ReadLine();
            
        }

        public virtual void ShowData()
        {
            Console.WriteLine("Furniture Details:\n");
            Console.WriteLine($"OrderId:{OrderId}\nOrderDate:{OrderDate}\nQuanity:{Quantity}\n" +
                $"Payment Mode:{PaymentMode}\nTotal Amount:{TotalAmount}");

            Console.WriteLine("".PadLeft(30, '-'));
        }

        #endregion

    }
}
