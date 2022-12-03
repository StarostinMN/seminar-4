/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */
Console.Clear();
Console.Write("Введите число  A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число  B: ");
int B = Convert.ToInt32(Console.ReadLine());

if (B <= 0)
{
    Console.WriteLine("В качестве числа B необходимо ввести натуральное число");
}
else
{
    Console.WriteLine($"{A} ^ {B} = {ComputingExp(A, B)}");
}

int ComputingExp(int a, int b)
{
    int exp = 1;
    for (int count = 1; count <= b; count++)
    {
        exp = exp * a;
    }
    return exp;
}