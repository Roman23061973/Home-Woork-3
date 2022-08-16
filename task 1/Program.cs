
Console.WriteLine("Введите координаты точки А по х");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки А по y");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки А по z");
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коорлинаты точки В по x");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки В по y");
double yB = Cjnvert.ToDouble(Console.ReadLine;
Console.WriteLine("Введите координаты точки В по z"));
double zB = Convert.ToDouble(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(xB - xA, 2)  + Math.Pow(yB - yA, 2) + Math.Pow(zB - za, 2));

Console.WriteLine($"{res:F2}");



