using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionTask
{
    internal class BankAccount
    {
        int account_number;
        string account_name;
        double balance,transaction_amount;
        char transaction_type;
        
        public int AccountNumber { get { return account_number; } set { account_number = value; } }
        public string AccountName { get { return account_name; } set { account_name = value; } }
        public double Balance { get { return balance; } set { balance = value; } }
        public double TransactionAmount { get { return transaction_amount; } set { transaction_amount = value; } }

        public char TransactionType { get { return transaction_type; } set { transaction_type = value; } }

        

        public void Getdata()
        {
            Random ran = new Random();
            Balance = ran.Next(300, 1000);
            //Balance = 1000;
            try
            {
                Console.WriteLine("Enter Account Number");
                AccountNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Account Name");
                AccountName = Console.ReadLine();
                Console.WriteLine("Enter Transaction type");
                TransactionType = char.Parse(Console.ReadLine());
                Console.WriteLine("Enter transaction amount");
                TransactionAmount = double.Parse(Console.ReadLine());
                if (Balance < 500)
                {
                    TransactionAmount = 0;
                    throw new BankException();
                }
                else
                {
                    if(TransactionType == 'd')
                    {
                        if (TransactionAmount < Balance)
                        {
                            Balance -= TransactionAmount;
                        }
                        else
                        {
                            Console.WriteLine("Balance is Insufficient");
                        }
                    }
                    else
                    {
                        Balance+=TransactionAmount;
                    }
                }
            }
            catch(BankException e)
            {
                e.MinBalance();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Account Number:{AccountNumber}\nAccout Name:{AccountName}\nBalance: {Balance}\n" +
                $"Transaction Type: {TransactionType}\nTransaction Amount:{TransactionAmount}");
        }

    }
}
