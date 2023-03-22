// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("Please, enter your number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, enter your number b: ");
int b = Convert.ToInt32(Console.ReadLine());
int st = 1;
for(int i = 1; i <= b; i++)
{
    st = st * a;
}
System.Console.WriteLine(st);

