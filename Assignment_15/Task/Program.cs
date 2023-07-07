using System;
using System.Numerics;
using System.Reflection;
using System.Security;
using Task;

PersonList personList = new PersonList();
CarList carList = new CarList();


Console.WriteLine("Please choose Classes: ");
Console.WriteLine("1.PersonList");
Console.WriteLine("2.CarList");
int input = int.Parse(Console.ReadLine());
switch (input)
{
    case 1:
        while (true)
        {
            Console.WriteLine("Choose Methods: ");
            var type = typeof(PersonList);
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                if (method.DeclaringType == type)
                {
                    Console.WriteLine(method.Name);
                }
            }
            Console.WriteLine("Exit");
            string input1 = Console.ReadLine();
            switch (input1)
            {
                case "AddPerson":
                    Console.WriteLine("FirstName: ");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Lastname: ");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Gender: ");
                    string gender = Console.ReadLine();
                    Console.WriteLine("Phone: ");
                    string phone = Console.ReadLine();
                    Person person = new Person(firstName, lastName, gender, phone);

                    type.GetMethod("AddPerson").Invoke(personList,BindingFlags.Public | BindingFlags.Instance, null, new object?[]{ person }, null);
                    break;
                case "GetPerson":
                    personList.GetPerson();
                    break;
                case "Exit":
                    Console.WriteLine("Exit");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    case 2:
        while (true)
        {
            Console.WriteLine("Choose Methods: ");
            var type = typeof(CarList);
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                if (method.DeclaringType == type)
                {
                    Console.WriteLine(method.Name);
                }
            }
            Console.WriteLine("Exit");
            string input1 = Console.ReadLine();
            switch (input1)
            {
                case "AddCar":
                    Console.WriteLine("Model: ");
                    string model = Console.ReadLine();
                    Console.WriteLine("Type: ");
                    string cartype = Console.ReadLine();
                    Console.WriteLine("Color: ");
                    string color = Console.ReadLine();
                   
                    Car car = new Car(model, cartype, color);
                    type.GetMethod("AddCar").Invoke(carList, BindingFlags.Public | BindingFlags.Instance, null, new object?[] { car }, null);
                    break;
                case "GetCar":
                    carList.GetCar();
                    break;
                case "Exit":
                    Console.WriteLine("Exit");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
        break;
    default:
        Console.WriteLine("");
        break;
}
