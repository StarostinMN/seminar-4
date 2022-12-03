//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11, 82 -> 10, 9012 -> 12
Console.Clear();
Console.Write("Введите целое число: ");
int NUMBER = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа {NUMBER} равна {ComputeDigitSum(NUMBER)}");

int ComputeDigitSum(int number)
{
    number = Math.Abs(number);
    int sum = 0;
    int digit = 1;
    for (int i = 0; digit > 0; i++)
    {
        digit = (int)(number % 10);
        number = (int)number / 10;
        sum = sum + digit;
    }
    return sum;
}