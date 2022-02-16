// Возведите число А в натуральную степень B, используя цикл.

// Console.WriteLine("Задайте число: ");
// int A = int.Parse(Console.ReadLine());
// Console.WriteLine("Задайте степень: ");
// int B = int.Parse(Console.ReadLine());
// int result = A * A;
// for (int I = 2; B > I; I++)
// {
//     result = result * A;
// }
// Console.WriteLine(result);

// Ниже второй вариант

Console.WriteLine("Задайте число: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте степень: ");
int B = int.Parse(Console.ReadLine());

int I = 2;
int result = A * A;

if (A == 0 && B == 0) Console.WriteLine("Ошибка. Задайте другое число или степень");
else if (B == 1) Console.WriteLine($"Число {A} в степени 1 равно {A}");    
else if (B == 0) Console.WriteLine("Любое число кроме нуля в степени 0 равно 1");
else
    while (B > I)
        {
            result = result * A;
            I++;
        }
    Console.WriteLine($"Число {A} в степени {B} = {result}");