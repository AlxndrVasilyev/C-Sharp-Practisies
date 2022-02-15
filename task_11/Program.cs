// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int MaxOfTwo(int max)
{
    int firstDigit = max % 10;
    int secondDigit = max / 10;
    int result = firstDigit;

    if (firstDigit > secondDigit) result = firstDigit;
    else if (secondDigit > firstDigit) result = secondDigit;
return result;
}
int n = new Random().Next(10, 100);
Console.WriteLine("Сгенерированное число: " + n);
Console.WriteLine("Наибольшая цифра числа: " + MaxOfTwo(n));