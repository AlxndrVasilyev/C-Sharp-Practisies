// Найти третью цифру числа или сообщить, что её нет.

int LastDigit(int num)
{
    return num % 10;
}

Console.WriteLine("Введите любое число");
int num = int.Parse(Console.ReadLine());
if (num < 100) Console.WriteLine("Число не является трёхзначным");
while (num >= 1000)
{
    num = num / 10;
}
Console.WriteLine("Третья цифра в числе: " + LastDigit(num));