using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class FormulaCar : SportsVehicle
    {
        private int _numberOfSeats;
        public int NumberOfSeats { get; set; }

        public FormulaCar(string motor, string wheel, string color, int maxSpeed,int numberOfSeats)
            :base(motor, wheel, color, maxSpeed)
        {
            _numberOfSeats = numberOfSeats;
        }
    }

    public class OffroadCar : SportsVehicle
    {
        private bool _bigTire;
        public bool BigTire { get;set; }

        public OffroadCar(string motor, string wheel, string color, int maxSpeed, bool bigTire)
            : base(motor, wheel, color, maxSpeed)
        {
            _bigTire = bigTire;
        }
    }
}
