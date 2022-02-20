// Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Задайте число: ");
double N = int.Parse(Console.ReadLine());
double result = 1;

for (int i = 1; i <= N; i++)
{
    result = result * i;
}
Console.WriteLine($"Произведение чисел от 1 до {N} = {result}");