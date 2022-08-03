using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsUseCase
{

    abstract class Device
    {

        public abstract Array GetDeviceDetails();
        public abstract Array StoreDevicesData();

        public abstract Array SearchSpecificDevice();
        public abstract void UpdateDeviceData();
    }


    class Laptop : Device
    {

        //public string Name,Model,Ram,Rom,Processor,Graphics,Price;
        public Array details = Array.CreateInstance(typeof(string), 7);
        Array LapDetails = Array.CreateInstance(typeof(Array), 5);


        public void StoreSingleInstance(String name, String model, string ram, string rom, string processor, string graphics, int price)
        {
            details.SetValue(name, 0);
            details.SetValue(model, 1);
            details.SetValue(ram, 2);
            details.SetValue(rom, 3);
            details.SetValue(processor, 4);
            details.SetValue(graphics, 5);
            details.SetValue(Convert.ToString(price), 6);
        }
        public override Array StoreDevicesData()
        {
            Console.WriteLine("How many laptop data you need to store?");
            int n = int.Parse(Console.ReadLine());
            //Array LapDetails = Array.CreateInstance(typeof(Array), n);
            for (int i = 0; i < n; i++)
            {

                String Name = Console.ReadLine();
                StoreSingleInstance(Name, "Sx13", "64Gb", "512Gb SSd", "i7-10thGen", "4GB-RTX", 135000);
                LapDetails.SetValue((Array)details.Clone(), i);

            }
            Console.WriteLine("\n Laptop data stored successfully");
            return LapDetails;
        }

        public override Array GetDeviceDetails()
        {
            return details;
        }

        public override void UpdateDeviceData()
        {
            Console.WriteLine("Entering into updation mode");
            //String model = Console.ReadLine();
            //String name = Console.ReadLine();
            Console.WriteLine("".PadLeft(30, '-'));

            Array dev = SearchSpecificDevice();
            Console.WriteLine("\n Following Device you selected for data updation\n");
            foreach (string i in dev)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("".PadLeft(30, '-'));
            int ch;

            do
            {
                Console.WriteLine("Select from following option:\n1.Update Ram\n2.Update Rom\n3.Update Processor\n4.Update Graphics\n5.Update Price\n-1.Exit");
                Console.WriteLine("".PadLeft(30, '-'));

                ch = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Updated detail");
                switch (ch)
                {
                    case 1:
                        dev.SetValue(Console.ReadLine(), 2);
                        break;
                    case 2:
                        dev.SetValue(Console.ReadLine(), 3);
                        break;
                    case 3:
                        dev.SetValue(Console.ReadLine(), 4);
                        break;
                    case 4:
                        dev.SetValue(Console.ReadLine(), 5);
                        break;
                    case 5:
                        dev.SetValue(Console.ReadLine(), 6);
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
            } while (ch >= 1);
        }

        public override Array SearchSpecificDevice()
        {
            Console.WriteLine("Enter Laptop Model and Name in separate line");
            String model = Console.ReadLine();
            String name = Console.ReadLine();
            Console.WriteLine("".PadLeft(30, '-'));

            foreach (Array item in LapDetails)
            {
                if (item.GetValue(1).ToString() == model && item.GetValue(0).ToString() == name)
                {
                    return item;

                }

            }
            return null;
        }
    }

}
