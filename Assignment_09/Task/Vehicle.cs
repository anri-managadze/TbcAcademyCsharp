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

        public string Motor
        {
            get
            {
                return _motor;
            }
            set
            { 
                _motor = value; 
            }

        }
        public string Wheel 
        {
            get 
            {
                return _wheel;
            }
            set 
            {
                _wheel = value;
             } 
        }
        public string Color 
        {
            get 
            {
                return _color;
            } 
            set
            {
                _color = value;
            }
        }

        public Vehicle(string motor, string wheel, string color)
        {
            _motor = motor;
            _wheel = wheel;
            _color = color;
        }

    }
}
