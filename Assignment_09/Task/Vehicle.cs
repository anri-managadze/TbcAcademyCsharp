using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Vehicle
    {
        private string _motor;
        private string _wheel;
        private string _color;

        public string Motor { get; set; }
        public string Wheel { get; set; }
        public string Color { get; set; } 

        public Vehicle(string motor, string wheel, string color)
        {
            _motor = motor;
            _wheel = wheel;
            _color = color;
        }

    }
}
