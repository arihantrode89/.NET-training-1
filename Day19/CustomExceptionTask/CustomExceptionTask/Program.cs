using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Boolean flg;
            do
            {
                Console.WriteLine("Choose\n1.Transaction\n2.Show Details");
                int ch = int.Parse(Console.ReadLine());
                
                
                flg = true;
                switch (ch)
                {
                    case 1:
                        account.Getdata();
                        flg = true;
                        break;
                    case 2:
                        account.ShowDetails();
                        flg = true;
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        flg = false;
                        break;


                }
            }while (flg);
        }
    }
}
