// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int n = new Random().Next(10, 100);
Console.WriteLine("Сгенерированное число: " + n);
int MaxOfTwo(int max)
{
    int firstDigit = max % 10;
    int secondDigit = max / 10;
    int result = -1;
    if (firstDigit > secondDigit)
    {
        result = firstDigit;
    }
    else if (secondDigit > firstDigit)
    {
        result = secondDigit;
    }
    else
    {
        Console.WriteLine("Наибольшей цифры нет");
    }
return result;
}
Console.WriteLine("Наибольшая цифра числа: " + MaxOfTwo(n));