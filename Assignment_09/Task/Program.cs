using System.Drawing;
using Task;



Console.WriteLine("Please, Enter: combat, consumer, public, sport");
string input = Console.ReadLine();
switch (input)
{
    case "combat":
        Console.WriteLine("Combat Type :tank, beteer, combathummer ");
        string input1 = Console.ReadLine();
        switch (input1)
        {
            case "tank":
                Console.WriteLine("Tank selected");
                Tank.CreateTank();
                break;
            case "beteer":
                Console.WriteLine("Beteer selected");
                Beteer.CreateBeteer();
                break;
            case "combathummer":
                Console.WriteLine("Combathummer selected");
                CombatHammer.CreateCombatHammer();
                break;
            default:
                Console.WriteLine("Invalid option for Combat Category");
                break;
        }
        break;
    case "consumer":
        Console.WriteLine("Consumer Category: sedan, jeep");
        string input2 = Console.ReadLine();
        switch (input2)
        {
            case "sedan":
                Console.WriteLine("Sedan selected");
                Sedan.CreateSedan();
                break;
            case "jeep":
                Console.WriteLine("Jeep selected");
                Jeep.CreateJeep();
                break;
            default:
                Console.WriteLine("Invalid option for Consumer Category");
                break;
        }
        break;
    case "public":
        Console.WriteLine("Public Category: bus, subway");
        string input3 = Console.ReadLine();
        switch (input3)
        {
            case "bus":
                Console.WriteLine("Bus selected");
                Bus.CreateBus();
                break;
            case "Subway":
                Console.WriteLine("Subway selected");
                Subway.CreateSubway();
                break;
            default:
                Console.WriteLine("Invalid option for Public Category");
                break;
        }
        break;
    case "sport":
        Console.WriteLine("Sport Category: offroad, formulacar");
        string input4 = Console.ReadLine();
        switch (input4)
        {
            case "offroad":
                Console.WriteLine("Offroad selected");
                OffroadCar.CreateOffroadCar();
                break;
            case "formulacar":
                Console.WriteLine("Formulacar selected");
                FormulaCar.CreateFormulaCar();
                break;
            default:
                Console.WriteLine("Invalid option for Sport Category");
                break;
        }
        break;
    default:
        Console.WriteLine("Invalid category");
        break;   
}

