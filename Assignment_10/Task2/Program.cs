using Task2;

Console.WriteLine("first triangle:");

Console.WriteLine("Side 1:");
double side1 = double.Parse(Console.ReadLine());
Console.WriteLine("Side 2:");
double side2 = double.Parse(Console.ReadLine());
Console.WriteLine("Side 3:");
double side3 = double.Parse(Console.ReadLine());

Triangle triagle1 = new Triangle(side1, side2, side3);


Console.WriteLine("second triangle:");

Console.WriteLine("Side 1:");
double t2Side_1 = double.Parse(Console.ReadLine());
Console.WriteLine("Side 2:");
double t2Side_2 = double.Parse(Console.ReadLine());
Console.WriteLine("Side 3:");
double t2Side_3 = double.Parse(Console.ReadLine());

Triangle triagle2 = new Triangle(t2Side_1, t2Side_2, t2Side_3);


bool result = triagle1 == triagle2;
Console.WriteLine(result);


bool result2 = triagle1 != triagle2;
Console.WriteLine(result2);


bool result3 = triagle1 < triagle2;
Console.WriteLine(result3);


bool result4 = triagle1 > triagle2;
Console.WriteLine(result4);


double side = double.Parse(Console.ReadLine());
Triangle equilateralTriangle = (Triangle)side;

Console.WriteLine("EquilateralTriangle: " + equilateralTriangle.CalculatePerimeter());
