// Найти расстояние между точками в пространстве 3D
Console.Clear();
Console.Write("Ddtlbnt x1 :");
int x1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Ddtlbnt y1 :");
int y1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Ddtlbnt z1 :");
int z1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Ddtlbnt x2 :");
int x2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Ddtlbnt y2 :");
int y2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Ddtlbnt z2 :");
int z2 = int.Parse(Console.ReadLine() ?? "0");
double distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
Console.WriteLine("Расстояние между точками равно: ");
Console.WriteLine(distance);
