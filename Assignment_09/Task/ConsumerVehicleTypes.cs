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
        public int NumberOfDoors
        {
            get { return _numberOfDoors; }
            set { _numberOfDoors = value; }
        }

        public Sedan(string motor, string wheel, string color, double mileage, int numberOfDoors)
            : base(motor, wheel, color, mileage)
        {
            _numberOfDoors = numberOfDoors;
        }
        public static void CreateSedan()
        {
            string motor = Console.ReadLine();
            string wheel = Console.ReadLine();
            string color = Console.ReadLine();
            double mileage = Convert.ToDouble(Console.ReadLine());
            int numberOfDoors = Convert.ToInt16(Console.ReadLine());
            Sedan sedan = new Sedan(motor, wheel, color, mileage, numberOfDoors);
            Console.Write(
               $"Motor: " + sedan.Motor + "," +
                "Wheel: " + sedan.Wheel + "," +
                "Color: " + sedan.Color + "," +
                "Weapon: " + sedan.Mileage + "," +
                "TankBarrel: " + sedan.NumberOfDoors
                );
        }
    }
    public class Jeep : ConsumerVehicle
    {
        private bool _highThroughput;
        public bool HighThroughPut
        {
            get
            { return _highThroughput; }
            set 
            {  _highThroughput = value; }
        }

        public Jeep(string motor, string wheel, string color, double mileage, bool highThroughput)
             : base(motor, wheel, color, mileage)
        {
            _highThroughput = highThroughput;
        }
        public static void CreateJeep()
        {
            string motor = Console.ReadLine();
            string wheel = Console.ReadLine();
            string color = Console.ReadLine();
            double mileage = Convert.ToDouble(Console.ReadLine());
            bool highThroughput = Convert.ToBoolean(Console.ReadLine());
            Jeep jeep = new Jeep(motor, wheel, color, mileage, highThroughput);
            Console.Write(
               $"Motor: " + jeep.Motor + "," +
                "Wheel: " + jeep.Wheel + "," +
                "Color: " + jeep.Color + "," +
                "Weapon: " + jeep.Mileage + "," +
                "TankBarrel: " + jeep.HighThroughPut
                );
        }
    }
}
