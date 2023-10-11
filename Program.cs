Console.WriteLine("Ввести длину ребра куба");
double x = Convert.ToDouble(Console.ReadLine());
Double y = x * x;
Console.WriteLine($"Площадь грани={y}");
double z = y * 6;
Console.WriteLine($"Площадь полной поверхности куба={z}");
double w = x*x*x;
Console.WriteLine($"Объем куба={w}");
