//Напишите программу, которая задаёт массив из 
// произвольного кол-ва элементови выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Please, enter the length of the array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] Array(int size)
{
    int [] arr = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Please, enter the number under the index {i}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write("]");
    System.Console.WriteLine();
}
PrintArray(Array(size));

// Все равно не понял как вывести так - [1, 2, 5, 7, 19]
//Если боьясните в следующем семинаре было бы неплохо)