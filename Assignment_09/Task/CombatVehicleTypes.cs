using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Tank : CombatVehicle
    {
        private string _tankBarrel;
        public string TankBarrel
        {
            get 
            {
                return _tankBarrel;
            }
            set 
            {
                _tankBarrel = value;
            } 
        }

        public Tank(string motor, string wheel, string color, string weapon, string tankbarrel)
            : base(motor, wheel, color, weapon)
        {
            _tankBarrel = tankbarrel;
        }
        public static void CreateTank()
        {
            string motor = Console.ReadLine();
            string wheel = Console.ReadLine();
            string color = Console.ReadLine();
            string weapon = Console.ReadLine();
            string tankbarrel = Console.ReadLine();
            Tank tank = new Tank(motor, wheel, color, weapon, tankbarrel);
            Console.Write(
               $"Motor: " + tank.Motor + "," +
                "Wheel: " + tank.Wheel + ","+
                "Color: " + tank.Color + "," +
                "Weapon: " + tank.Weapon + "," +
                "TankBarrel: " + tank.TankBarrel
                );
        }
    }

    public class Beteer : CombatVehicle
    {
        private string _machineGun;
        public string MachinGun 
        {
            get 
            { 
                return _machineGun; 
            } 
            set 
            {
                _machineGun = value; 
            }
        }

        public Beteer(string motor, string wheel, string color, string weapon,string machineGun)
            : base(motor, wheel, color, weapon)
        {
            _machineGun = machineGun;
        }
        public static void CreateBeteer()
        {
            string motor = Console.ReadLine();
            string wheel = Console.ReadLine();
            string color = Console.ReadLine();
            string weapon = Console.ReadLine();
            string machineGun = Console.ReadLine();
            Beteer beteer = new Beteer(motor, wheel, color, weapon, machineGun);
            Console.Write(
               $"Motor: " + beteer.Motor + "," +
                "Wheel: " + beteer.Wheel + "," +
                "Color: " + beteer.Color + "," +
                "Weapon: " + beteer.Weapon + "," +
                "TankBarrel: " + beteer.MachinGun
                );
        }
    }

    public class CombatHammer : CombatVehicle
    {
        private string _armor;
        public string Armor 
        {
            get 
            {
                return _armor;  
            }
            set 
            {
                _armor = value;
            }
        }

        public CombatHammer(string motor, string wheel, string color, string weapon, string armor)
            : base(motor, wheel, color, weapon)
        {
            _armor = armor;
        }
        public static void CreateCombatHammer()
        {
            string motor = Console.ReadLine();
            string wheel = Console.ReadLine();
            string color = Console.ReadLine();
            string weapon = Console.ReadLine();
            string armor = Console.ReadLine();
            CombatHammer combatHammer = new CombatHammer(motor, wheel, color, weapon, armor);
            Console.Write(
               $"Motor: " + combatHammer.Motor + "," +
                "Wheel: " + combatHammer.Wheel + "," +
                "Color: " + combatHammer.Color + "," +
                "Weapon: " + combatHammer.Weapon + "," +
                "TankBarrel: " + combatHammer.Armor
                );
        }
    }
}
