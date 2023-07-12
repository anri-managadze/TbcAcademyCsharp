using System.Reflection;
using Task1;

var calc = new Calculator();
Console.WriteLine("Choose Methods: ");
var type = typeof(Calculator);
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
MyDelegate del;
MyDelegate1 del1;

double a;
double b;
switch (input1)
{
    case "Add":
        Console.WriteLine("Enter the first number:");
        a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        b = double.Parse(Console.ReadLine());
        del = calc.Add;
        Console.WriteLine(del(a, b));
        break;
    case "Substract":
        Console.WriteLine("Enter the first number:");
        a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        b = double.Parse(Console.ReadLine());

        del = calc.Substract;
        Console.WriteLine(del(a, b));
        break;
    case "Multiply":
        Console.WriteLine("Enter the first number:");
        a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        b = double.Parse(Console.ReadLine());

        del = calc.Multiply;
        Console.WriteLine(del(a, b));
        break;
    case "Devide":
        Console.WriteLine("Enter the first number:");
        a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        b = double.Parse(Console.ReadLine());

        del = calc.Devide;
        Console.WriteLine(del(a, b));
        break;
    case "Pow":
        Console.WriteLine("Enter the first number:");
        a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        b = double.Parse(Console.ReadLine());

        del = calc.Pow;
        Console.WriteLine(del(a, b));
        break;
    case "Sqrt":
        Console.WriteLine("Enter the number:");
        a = double.Parse(Console.ReadLine());

        del1 = calc.Sqrt;
        Console.WriteLine("Sqrt: " + del1(a));
        break;
    case "Exit":
        Console.WriteLine("Exit");
        return;
    default:
        Console.WriteLine("Invalid choice. Try again.");
        break;
}
public delegate double MyDelegate(double value1, double value2);
public delegate double MyDelegate1(double value);
