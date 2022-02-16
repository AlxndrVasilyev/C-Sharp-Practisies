// Возведите число А в натуральную степень B, используя цикл.
Console.WriteLine("Задайте число: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте степень: ");
int B = int.Parse(Console.ReadLine());
int I = 2;
int result = A * A;
while (B > I)
{
    result = result * A;
    I++;
}
Console.WriteLine(result);