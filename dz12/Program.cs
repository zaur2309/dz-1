//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Введите число: ");
int aa = Convert.ToInt32(Console.ReadLine());
int Summ (int a)
{
    int a1 = 0;
    int summa=0;
    while (a!=0)
    {        
        a1 = a % 10;
        summa = summa + a1;
        a = a / 10;
    }
    return summa;
}

int summa = Summ(aa);
System.Console.WriteLine(summa);