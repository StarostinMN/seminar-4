/* Демонстрация решения
Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36 */

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел от 1 до {number} равна {FindSumTolimit(number)}");

int FindSumTolimit(int limit)
{
    int sum = 0;
    for (int i = 0; i <= limit; i++)
    {
        sum += i;
    }
    return sum;
}