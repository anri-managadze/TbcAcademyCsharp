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
        public string Weapon
        { 
            get { return _weapon; }
            set { _weapon = value; }
        }

        public CombatVehicle(string motor, string wheel, string color, string weapon) 
            : base(motor,wheel,color)
        {
            _weapon = weapon;
        }
    }
    public class ConsumerVehicle :Vehicle
    {
        private double _mileage;
        public double Mileage 
        { 
            get { return _mileage; }
            set { _mileage = value; }
        }

        public ConsumerVehicle(string motor, string wheel, string color,double mileage)
            : base(motor, wheel, color)
        {
            _mileage = mileage;
        }
    }

    public class PublicVehicle : Vehicle
    {
        private int _NumberOfFloors;
        public int NumberOfFloors 
        { 
            get { return _NumberOfFloors; }
            set { _NumberOfFloors = value; }
        }
        public PublicVehicle(string motor, string wheel, string color, int numberOfFloors)
            : base(motor, wheel, color)
        {
            _NumberOfFloors = numberOfFloors;
        }
    }

    public class SportsVehicle : Vehicle
    {
        private int _maxSpeed;

        public int MaxSpeed 
        { 
            get { return _maxSpeed; }
            set { _maxSpeed = value; }
        }

        public SportsVehicle(string motor, string wheel, string color, int maxSpeed) 
            : base(motor, wheel, color)
        {
            _maxSpeed = maxSpeed;
        }
    }


}
