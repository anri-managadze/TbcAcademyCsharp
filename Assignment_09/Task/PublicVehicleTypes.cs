using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Bus : PublicVehicle
    {
        private int _numberOfPassengers;
        public int numberOfPassengers { get;set; }
        public Bus(string motor, string wheel, string color, int numberOfFloors,int numberOfPassengers)
            : base(motor, wheel, color, numberOfFloors)
        {
            _numberOfPassengers = numberOfPassengers;
        }
    }

    public class Subway : PublicVehicle
    {
        private int _numberOfWagons;
        public int NumberOfWagons { get; set; }
        public Subway(string motor, string wheel, string color, int numberOfFloors,int numberOfWagons)
            : base(motor, wheel, color, numberOfFloors)
        {
            _numberOfWagons = numberOfWagons;
        }
    }
}
