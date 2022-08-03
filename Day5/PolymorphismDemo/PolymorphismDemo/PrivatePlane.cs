using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    public class PrivatePlane:Plane
    {
        public override void Takeoff()
        {
            Console.WriteLine("Can only take off for VIPs");
        }

        public override void Comm()
        {
            Console.WriteLine("This plane can communicate with Airport supporting private planes");
        }

        public override void desc()
        {
            Console.WriteLine("This is Private plane");
        }
    }
}
