// Даны два числа. Показать большее и меньшее из них.

Console.WriteLine("Введите первое целое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine(a + "  " + b);
}
else
{
    Console.WriteLine(b + "  " + a);
}
