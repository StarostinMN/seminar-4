/* Дополнительная задача (задача со звёздочкой): Напишите программу, которая на вход принимает радиус круга и находит его площадь округленную до целого числа, необходимо вывести максимальную цифру в полученном округлённом значении площади круга.
10 -> 4, 20 -> 7, 30 -> 8 */
Console.Clear();
Console.Write("Введите радиус круга: ");
int R = Convert.ToInt32(Console.ReadLine());

if (R < 0)
{
    Console.WriteLine("Радиус круга не может быть отрицательным числом, повторите ввод.");
}
else if (R == 0)
{
    Console.WriteLine("Радиус и площадь круга равны нулю, повторите ввод.");
}
else
{
    Console.WriteLine($"Округленное до целого числа значение площади круга радиуса {R} равно {ComputeCircleSquare(R)}");
    Console.WriteLine($"Максимальная цифра в полученном значении: {FindMaxDigit(ComputeCircleSquare(R))}");
}

int ComputeCircleSquare(int radius)
{
    int square;
    square = (int)Math.Round((Math.PI * radius * radius), 0);
    return square;
}

int FindMaxDigit(int number)
{
    int max = 0;
    int digit = 0;
    for (int i = 0; number > 0; i++)
    {
        digit = number % 10;
        if (digit > max) max = digit;
        number = (int)number / 10;
    }
    return max;
}
