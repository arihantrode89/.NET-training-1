using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    public class Plane
    {
        public Plane()
        {
            Console.WriteLine("Base class for all the planes");
        }
        
        public virtual void desc()
        {
            Console.WriteLine("This is normal Plane");
        }

        public void calculatemileage(float _fuel_price, float _dist,float  _total_fuel)
        {
            float _mileage = (_dist / _total_fuel) * _fuel_price;
            Console.WriteLine("Mileage is {0}", _mileage);        
        }

        public virtual void Comm()
        {
            Console.WriteLine("This plane can contact Any nearby airport");
        }

        public virtual void Takeoff()
        {
            Console.WriteLine("Can take off on scheduled time");
        }
    }
}
