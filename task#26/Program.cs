/* Решение в группах задач:
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
 */
Console.Clear();
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Количество цифр в числе {number} равно {FindCountNumber(number)}");

int FindCountNumber(int Number)
{
    Number=Math.Abs(Number);
    int CountNumber = 0;
    for (int i = 0; Number > 0; i++)
        {
            Number = Number / 10;
            CountNumber++;
        }
}
