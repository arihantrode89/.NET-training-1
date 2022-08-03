using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Airport a = new Airport();
            FighterPlane f = new FighterPlane();
            a.Air(f);

            Console.WriteLine("".PadLeft(30, '-'));

            PrivatePlane p = new PrivatePlane();
            a.Air(p);
        }
    }
}
