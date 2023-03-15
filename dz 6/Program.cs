// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a>99 && a<1000)
{
    Console.WriteLine(a%10);
}
if (a<99)
{
    Console.WriteLine("третьей цыфры нет");
}
if (a>999)
{
    while (a>999)
    {
        a = a / 10;
    }
    Console.WriteLine(a%10);
}