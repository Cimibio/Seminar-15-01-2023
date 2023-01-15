// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите X не равное 0:");
int X = int.Parse(Console.ReadLine());
while (X == 0)
{
    Console.WriteLine("Вы ввели 0, попробуйте ещё раз:");
    X = int.Parse(Console.ReadLine());
}
Console.WriteLine("Введите Y не равное 0:");
int Y = int.Parse(Console.ReadLine());
while (Y == 0)
{
    Console.WriteLine("Вы ввели 0, попробуйте ещё раз:");
    Y = int.Parse(Console.ReadLine());
}
if (X > 0 && Y > 0)
{
   Console.WriteLine("Первая четверть"); 
}
else if (X > 0 & Y < 0)
{
   Console.WriteLine("Четвертая четверть"); 
}
else if (X < 0 & Y > 0)
{
   Console.WriteLine("Вторая четверть"); 
}
else
{
   Console.WriteLine("Третья четверть"); 
}