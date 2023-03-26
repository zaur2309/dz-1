// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// // 3 -> 1, 8, 27
// // // 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write($"{N}-> ");
// for (int i = 1; i <= N; i++)
// Console.Write( i * i * i + ", ");

Console.Write("Please, enter the length of the array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] CreateArray(int size)                               
{
    int[] arr = new int [size];
    for(int i = 0; i < size; i++)
    {
        System.Console.Write("Введите элмент массива: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int[] arr = CreateArray(size);
void PrintArray(int size, int[] arr)
{   
    Console.Write("[");
    for(int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("]");
    Console.WriteLine();
    
}
PrintArray(size, arr);

//Функция для вывода массива на экран
