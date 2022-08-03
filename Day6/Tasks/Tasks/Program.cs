using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactInfo obj = new ContactInfo("Deshpande","Ngp","Mh","IND","0012","arihant@gmail.com");
            ContactInfoManager obj1 = new ContactInfoManager();
            
            obj1.displayContact(obj);
            Console.WriteLine("".PadLeft(30, '-'));
            obj1.createContact(obj);
            obj1.displayContact(obj);

        }
    }
}
