using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsUseCase
{
    

    
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;

            //Array lapdetails = Array.CreateInstance(typeof(Array),5);
            Array lapdetails = new Array[] { };
            Laptop obj = new Laptop();
            do
            {
               
                Console.WriteLine("Enter Your Choice");
                Console.WriteLine(" 1.For storage \n 2.Retreiving all details \n 3.Retrieving specific details \n 4.Update Details \n -1.Exit\n" + "".PadLeft(30, '-'));
                ch = int.Parse(Console.ReadLine());
               
                switch (ch)
                {
                    case 1:
                        
                        lapdetails = obj.StoreDevicesData();

                        break; 
                    case 2:
                        // for getting details of evry laptop
                        foreach(Array item in lapdetails)
                        {
                            
                            foreach(String item2 in item)
                            {
                                Console.WriteLine(item2);
                            }

                            Console.WriteLine("".PadLeft(30,'-'));
                        }
                        break;
                    case 3:
                        //for getting specific laptop details
                        Array spec = obj.SearchSpecificDevice();
                        foreach(String spec2 in spec)
                        {
                            Console.WriteLine(spec2);
                        }
                        Console.WriteLine("".PadLeft(30,'-'));

                        break;
                    case 4:
                        //for updating specific data
                        obj.UpdateDeviceData();
                        break;
                    default:
                        Console.WriteLine("Select Correct Option");
                        break;

                }
            }while(ch>=0);



        }
    }
}
