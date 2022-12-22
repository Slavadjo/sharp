// выяснить является ли число чётным.

Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 1)
{
    Console.WriteLine($"число {a} нечетное");
}
else
{
    Console.WriteLine($"Число {a} четное");
}
