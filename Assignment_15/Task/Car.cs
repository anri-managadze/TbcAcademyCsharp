using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Car
    {

        private string _model;
        private string _type;
        private string _color;

        public Car(string model, string type, string color)
        {
            _model = model;
            _type = type;
            _color = color;
        }
        public string Model { get { return _model; } set { _model = value; } }  
        public string Type { get { return _type; } set { _type = value; } }
        public string Color { get { return _color; } set { _color = value; } }

    }
}
