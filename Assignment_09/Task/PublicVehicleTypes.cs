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
        public int numberOfPassengers
        {
            get { return _numberOfPassengers; }
            set { _numberOfPassengers = value;}
        }
        public Bus(string motor, string wheel, string color, int numberOfFloors,int numberOfPassengers)
            : base(motor, wheel, color, numberOfFloors)
        {
            _numberOfPassengers = numberOfPassengers;
        }
        public static void CreateBus()
        {
            string motor = Console.ReadLine();
            string wheel = Console.ReadLine();
            string color = Console.ReadLine();
            int numberOfFloors = Convert.ToInt16(Console.ReadLine());
            int numberOfPassengers = Convert.ToInt16(Console.ReadLine());
            Bus bus = new Bus(motor, wheel, color, numberOfFloors, numberOfPassengers);
            Console.Write(
               $"Motor: " + bus.Motor + "," +
                "Wheel: " + bus.Wheel + "," +
                "Color: " + bus.Color + "," +
                "Weapon: " + bus.NumberOfFloors + "," +
                "TankBarrel: " + bus.numberOfPassengers
                );
        }
    }

    public class Subway : PublicVehicle
    {
        private int _numberOfWagons;
        public int NumberOfWagons
        {
            get { return _numberOfWagons; }
            set { _numberOfWagons = value; }
        }
        public Subway(string motor, string wheel, string color, int numberOfFloors,int numberOfWagons)
            : base(motor, wheel, color, numberOfFloors)
        {
            _numberOfWagons = numberOfWagons;
        }
        public static void CreateSubway()
        {
            string motor = Console.ReadLine();
            string wheel = Console.ReadLine();
            string color = Console.ReadLine();
            int numberOfFloors = Convert.ToInt16(Console.ReadLine());
            int numberOfWagons = Convert.ToInt16(Console.ReadLine());
            Subway subway = new Subway(motor, wheel, color, numberOfFloors, numberOfWagons);
            Console.Write(
               $"Motor: " + subway.Motor + "," +
                "Wheel: " + subway.Wheel + "," +
                "Color: " + subway.Color + "," +
                "Weapon: " + subway.NumberOfFloors + "," +
                "TankBarrel: " + subway.NumberOfWagons
                );
        }
    }
}
