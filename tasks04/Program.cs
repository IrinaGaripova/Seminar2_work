// Найти расстояние между точками в пространстве 2D
Console.Clear();
Console.Write("Ddtlbnt x1 :");
int x1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Ddtlbnt y1 :");
int y1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Ddtlbnt x2 :");
int x2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Ddtlbnt y2 :");
int y2 = int.Parse(Console.ReadLine() ?? "0");
double distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
Console.WriteLine("Расстояние между точками равно: ");
Console.WriteLine(distance);
