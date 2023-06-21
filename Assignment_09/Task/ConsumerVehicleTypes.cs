using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Sedan : ConsumerVehicle
    {
        private int _numberOfDoors;
        public int NumberOfDoors { get;set; }

        public Sedan(string motor, string wheel, string color, double mileage, int numberOfDoors)
            : base(motor, wheel, color, mileage)
        {
            _numberOfDoors = numberOfDoors;
        }
    }
    public class Jeep : ConsumerVehicle
    {
        private bool _highThroughput;
        public bool HighThroughPut { get; set; }

        public Jeep(string motor, string wheel, string color, double mileage, bool highThroughput)
             : base(motor, wheel, color, mileage)
        {
            _highThroughput = highThroughput;
        }
    }

}
