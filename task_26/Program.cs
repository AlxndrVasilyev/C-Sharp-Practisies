// Возведите число А в натуральную степень B, используя цикл.

Console.WriteLine("Задайте число: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте степень: ");
int B = int.Parse(Console.ReadLine());
int result = A;
for (int I = 1; B > I; I++)
{
    result = result * A;
}
Console.WriteLine($"Число {A} в степени {B} = {result}");

// Ниже вариант через while

// Console.WriteLine("Задайте число: ");
// int A = int.Parse(Console.ReadLine());
// Console.WriteLine("Задайте степень: ");
// int B = int.Parse(Console.ReadLine());
// int I = 1;
// int result = A;
// while (B > I)
//     {
//         result = result * A;
//         I++;
//     }
// Console.WriteLine($"Число {A} в степени {B} = {result}");