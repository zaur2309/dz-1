﻿Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0 && number != 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
