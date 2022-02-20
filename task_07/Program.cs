// Показать числа от -N до N

Console.Write("Введите целое число ");
int N = int.Parse(Console.ReadLine());

int i = -N;

while (i <= N)
{
Console.WriteLine (i);
i++;
}