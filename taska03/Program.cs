// Задать номер четверти, показать диапазоны для возможных координат
Console.Clear();
Console.WriteLine("Определить номер четверти");

Console.WriteLine("Введите первую координату: ");
int x = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введитt вторую координату: ");
int y = int.Parse(Console.ReadLine() ?? "0");
if (x>0 && y>0)
{
  Console.WriteLine("Номер четверти - 1");
}

else if (x<0 && y>0)
{
    Console.WriteLine("Номер четверти - 2");   
}
else if (x<0 && y<0)
{
    Console.WriteLine("Номер четверти - 3"); 
}
else if (x>0 && y<0)
{
    Console.WriteLine("Номер четверти - 4"); 
}