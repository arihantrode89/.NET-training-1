using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    internal class Airport
    {
        public void Air(Plane P)
        {
            P.desc();
            P.Comm();
            P.Takeoff();
            P.calculatemileage(1000,200,10000);
        }
    }
}
