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
        public int NumberOfSeats 
        {
            get { return _numberOfSeats; }
            set { _numberOfSeats = value; } 
        }

        public FormulaCar(string motor, string wheel, string color, int maxSpeed,int numberOfSeats)
            :base(motor, wheel, color, maxSpeed)
        {
            _numberOfSeats = numberOfSeats;
        }
        public static void CreateFormulaCar()
        {
            string motor = Console.ReadLine();
            string wheel = Console.ReadLine();
            string color = Console.ReadLine();
            int maxSpeed = Convert.ToInt16(Console.ReadLine());
            int numberOfSeats = Convert.ToInt16(Console.ReadLine());
            FormulaCar formulaCar = new FormulaCar(motor, wheel, color, maxSpeed,  numberOfSeats);
            Console.Write(
               $"Motor: " + formulaCar.Motor + "," +
                "Wheel: " + formulaCar.Wheel + "," +
                "Color: " + formulaCar.Color + "," +
                "Weapon: " + formulaCar.MaxSpeed + "," +
                "TankBarrel: " + formulaCar.NumberOfSeats
                );
        }

    }

    public class OffroadCar : SportsVehicle
    {
        private bool _bigTire;
        public bool BigTire 
        { 
            get {return _bigTire;}
            set {_bigTire = value;}
        }

        public OffroadCar(string motor, string wheel, string color, int maxSpeed, bool bigTire)
            : base(motor, wheel, color, maxSpeed)
        {
            _bigTire = bigTire;
        }
        public static void CreateOffroadCar()
        {
            string motor = Console.ReadLine();
            string wheel = Console.ReadLine();
            string color = Console.ReadLine();
            int maxSpeed = Convert.ToInt16(Console.ReadLine());
            bool bigTire = Convert.ToBoolean(Console.ReadLine());
            OffroadCar offroadCar = new OffroadCar(motor, wheel, color, maxSpeed, bigTire);
            Console.Write(
               $"Motor: " + offroadCar.Motor + "," +
                "Wheel: " + offroadCar.Wheel + "," +
                "Color: " + offroadCar.Color + "," +
                "Weapon: " + offroadCar.MaxSpeed + "," +
                "TankBarrel: " + offroadCar.BigTire
                );
        }
    }
}
