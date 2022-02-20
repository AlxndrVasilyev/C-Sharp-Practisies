// Найти максимальное из трех чисел

Console.WriteLine("Генерирую три случайных числа: ");

int n1 = new Random().Next(1,5);
int n2 = new Random().Next(1,5);
int n3 = new Random().Next(1,5);

Console.WriteLine("Первое число: " + n1);
Console.WriteLine("Второе число: " + n2);
Console.WriteLine("Третье число: " + n3);

if (n1 > n2 && n1 > n3)
{
    Console.WriteLine(n1 + " - максимальное число");
}
else if (n2 > n1 && n2 > n3)
{
    Console.WriteLine(n2 + " - максимальное число");
}
else if (n3 > n1 && n3 > n2)
{
    Console.WriteLine(n3 + " - максимальное число");
}
else if (n1 == n2 && n1 == n3)
{
    Console.WriteLine("Максимального числа нет, все равны");
}
else if (n1 == n2)
{
    Console.WriteLine("Максимальное число повторяется и равно " + n1);
}
else
{
    Console.WriteLine("Максимальное число повторяется и равно " + n1);
}