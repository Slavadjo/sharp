//Найти максимальное из трех чисел.
Console.WriteLine("Введите первое целое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое целое число");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (b > a)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine($"Максимальное из трех чисел {max}");
