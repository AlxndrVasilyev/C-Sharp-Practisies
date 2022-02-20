// Найти сумму чисел от 1 до А

Console.WriteLine("Задайте число: ");
int A = int.Parse(Console.ReadLine());
int result = 0;

for (int i = 0; i <= A; i++)
{
    result = result + i;
}
Console.WriteLine($"Сумма чисел от 1 до {A} = {result}");