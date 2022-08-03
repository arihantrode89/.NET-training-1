using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    class FighterPlane:Plane
    {
        public override void Takeoff()
        {
            Console.WriteLine("Can only take off while war and training");
        }

        public override void Comm()
        {
            Console.WriteLine("This plane can communicate with IAF");
        }

        public override void desc()
        {
            Console.WriteLine("This is fighter plane");
        }
    }
}
