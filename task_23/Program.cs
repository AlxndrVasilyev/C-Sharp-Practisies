// Показать таблицу квадратов чисел от 1 до N

Console.WriteLine("Задайте число N");
int N = int.Parse(Console.ReadLine());

Console.Write("Число \t \t");
for (int i = 1; i <= N; i++)
{
    Console.Write(i + "\t");
}

Console.WriteLine();

Console.Write("Квадрат числа \t");
for (int i = 1; i <= N; i++)
{
    Console.Write(i * i + "\t");
}

Console.WriteLine();
