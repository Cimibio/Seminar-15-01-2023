// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите пятизначное число");
int num = int.Parse(Console.ReadLine());
Console.Write("отстаток от деления на 10000:");
Console.WriteLine(num%10000);
Console.Write("отстаток от деления на 1000:");
Console.WriteLine(num%1000);
Console.Write("отстаток от деления на 100:");
Console.WriteLine(num%100);
Console.Write("отстаток от деления на 10, она же последняя цифра: ");
Console.WriteLine(num%10);
Console.WriteLine();

Console.Write("вторая цифра: ");
Console.WriteLine((num%10000 - num%1000) / 1000);

Console.Write("Четвертая цифра: ");
Console.WriteLine((num%100 - num%10) / 10);

Console.Write("Первая цифра: ");
Console.WriteLine((num - num%10000) / 10000);

//Console.WriteLine(num/10000);
//Console.WriteLine(num/1000);
//Console.WriteLine(num/100);
//Console.WriteLine(num/10);

if (((num / 10000) == num%10) && (((num%10000 - num%1000) / 1000) == ((num%100 - num%10) / 10))) Console.Write("число является полиндромом");
else Console.Write("число НЕ является полиндромом");