Console.WriteLine("Введите число для проверки кратности 7 и 23");
int num = int.Parse(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine("Число " + num + " кратно 7 и 23");
}
else 
{
    Console.WriteLine("Число " + num + " Не кратно 7 и 23");
}