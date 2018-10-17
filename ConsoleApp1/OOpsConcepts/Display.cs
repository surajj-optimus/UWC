using DotNetAssignments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OOpsConcepts
{
    public class Display
    {
        public static void Main()
        {
            Truck truck = new Truck();
            Car car = new Car();
            Bike bike = new Bike();
            Bicycle bicycle = new Bicycle();
            OutputService<string>.Display("truck status moving? " + truck.IsMoving().ToString());
            OutputService<string>.Display("car status moving? " + car.IsMoving().ToString());
            OutputService<string>.Display("bike status moving? " + bike.IsMoving().ToString());
            OutputService<string>.Display("bicycle status moving? " + bicycle.IsMoving().ToString());
            
            
            
            ;
        }
    }
}
