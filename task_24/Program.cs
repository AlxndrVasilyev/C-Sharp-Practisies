// Найти кубы чисел от 1 до N

Console.WriteLine("Задайте число N");
int N = int.Parse(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    Console.WriteLine($"{i} в кубе = {i * i * i}");
}