using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class CombatVehicle : Vehicle
    {
        private string _weapon;
        public string Weapon { get; set; }

        public CombatVehicle(string motor, string wheel, string color, string weapon) 
            : base(motor,wheel,color)
        {
            _weapon = weapon;
        }
    }
    public class ConsumerVehicle :Vehicle
    {
        private double _mileage;
        public double Mileage { get; set; }

        public ConsumerVehicle(string motor, string wheel, string color,double mileage)
            : base(motor, wheel, color)
        {
            _mileage = mileage;
        }
    }

    public class PublicVehicle : Vehicle
    {
        private int _NumberOfFloors;
        public int NumberOfFloors { get; set; }
        public PublicVehicle(string motor, string wheel, string color, int numberOfFloors)
            : base(motor, wheel, color)
        {
            _NumberOfFloors = numberOfFloors;
        }
    }

    public class SportsVehicle : Vehicle
    {
        private int _maxSpeed;

        public int MaxSpeed { get; set; }

        public SportsVehicle(string motor, string wheel, string color, int maxSpeed) 
            : base(motor, wheel, color)
        {
            _maxSpeed = maxSpeed;
        }
    }


}
