using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Tank : CombatVehicle
    {
        private string _tankBarrel;
        public string TankBarrel { get;set; }

        public Tank(string motor, string wheel, string color, string weapon, string tankbarrel)
            : base(motor, wheel, color, weapon)
        {
            _tankBarrel = tankbarrel;
        }
    }

    public class Beteer : CombatVehicle
    {
        private string _machineGun;
        public string MachinGun {get; set;}

        public Beteer(string motor, string wheel, string color, string weapon,string machineGun)
            : base(motor, wheel, color, weapon)
        {
            _machineGun = machineGun;
        }
    }

    public class CombatHammer : CombatVehicle
    {
        private string _armor;
        public string Armor { get; set;}

        public CombatHammer(string motor, string wheel, string color, string weapon, string armor)
            : base(motor, wheel, color, weapon)
        {
            _armor = armor;
        }
    }

}
