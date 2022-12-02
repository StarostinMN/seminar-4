/* Решение в группах задач:
Задача 28: Напишите программу, которая принимает на вход число M и N и выдаёт произведение чисел от M до N.
2,4 -> 24 
1,5 -> 120 */
Console.Clear();
Console.Write("Введите число M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N = ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Произведение чисел от начального до конечного равно {ProductFromStartToEnd(M, N)}");

int ProductFromStartToEnd(int num0, int num1)
{
    int product = 1;
    int start, end;
    if (num0 > num1)
    {
        start = num1;
        end = num0;
    }
    else
    {
        start = num0;
        end = num1;
    }
    for (int i = start; i <= end; i++)
    {
        product = product * i;
    }
    return product;
}