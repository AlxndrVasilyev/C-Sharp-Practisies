// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int MaxOfTwo(int max)
{
    int firstDigit = max % 10;
    int secondDigit = max / 10;
    int result = secondDigit;
    if (firstDigit > secondDigit) result = firstDigit;
    return result;
}
int n = new Random().Next(10, 100);
Console.WriteLine("Сгенерированное число: " + n);
Console.WriteLine("Наибольшая цифра числа: " + MaxOfTwo(n));