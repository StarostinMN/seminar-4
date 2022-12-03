/* Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран. Размерность массива вводится с клавиатуры.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
 */
Console.Clear();
Console.Write("Введите число элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] ARRAY = new int[Math.Abs(N)];

if (N <= 0)
{
    Console.WriteLine("Некорректные данные, введите целое положительное число");
}
else
{
FillArray(ARRAY);
Console.Write("[");
PrintArray(ARRAY);
Console.Write("]");
Console.WriteLine();
}

void FillArray(int[] fill)
{
    int length = fill.Length;
    for (int index = 0; index < length; index++)
    {
        fill[index] = new Random().Next(0, 100);
    }
}

void PrintArray(int[] print)
{
    int size = print.Length;
    for (int position = 0; position < size - 1; position++)
    {
        Console.Write($"{print[position]}, ");
    }
    Console.Write($"{print[size-1]}");
}

