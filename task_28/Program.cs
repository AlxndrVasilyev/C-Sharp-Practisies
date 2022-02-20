// Подсчитать сумму цифр в числе

Console.WriteLine("Введите любое целое число");
int num = int.Parse(Console.ReadLine());
int result = 0;
while (num != 0)
{
    result = result + num % 10;
    num = num / 10;
}
Console.WriteLine($"Сумма цифр в числе = {result}");