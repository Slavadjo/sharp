﻿// Напишите программу, которая будет выдавать 
// название дня недели по заданному номеру.
// 3 -> среда
// 5 -> пятница

Console.WriteLine("Введите целое число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("День недели - Понедельник");
}
else if (number == 2)
{
    Console.WriteLine("День недели - Вторник");
}
else if (number == 3)
{
    Console.WriteLine("День недели - Среда");
}
else if (number == 4)
{
    Console.WriteLine("День недели - Четверг");
}
else if (number == 5)
{
    Console.WriteLine("День недели - Пятница");
}
else if (number == 6)
{
    Console.WriteLine("День недели - Суббота");
}
else if (number == 7)
{
    Console.WriteLine("День недели - Воскресенье");
}