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

//Console.Write("Ведите число: ");
//int number = int.Parse(Console.ReadLine());
//int mod = 0;
//int newmod = 0;
//int i=0;
//for(i= number;number!=0;number=number/10)
//{
//    mod = number % 10;
//    newmod = newmod*10 + mod;
//}
//if(i == newmod) Console.WriteLine("Число палиндром");
//else Console.WriteLine("число не является палиндромом");

//Console.Write("Ведите число: ");
//int number = int.Parse(Console.ReadLine());
//int result = 0;
//int copy = number; // сохранем оригинальное число
//while (copy > 0)
//
//{
//    int last = copy % 10; //присваиваем переменной last значение последнего числа
//    result = result % 10 + last; //формируется перевернутое число
//    copy = copy / 10; // уменьшаем число на один знак справа
//}
//if(number == result) Console.WriteLine("Число палиндром");
//else Console.WriteLine("число не является палиндромом");