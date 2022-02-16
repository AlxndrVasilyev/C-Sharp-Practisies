// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Задайте первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте второе число: ");
int b = int.Parse(Console.ReadLine());
if (b == 0) Console.WriteLine("На ноль делить нельзя, перезапустите программу");
else
{
    int Div = a % b;
    {
        if (Div == 0) Console.WriteLine(a + " кратно " + b);
        else Console.WriteLine(a + " не кратно " + b + " и остаток от деления на целое = " + Div);
    }
}