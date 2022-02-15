// Показать вторую цифру трёхзначного числа

int SecondDigit(int Number)
{
    return Number / 10 % 10;
}
Console.WriteLine("Введите трёхзначное число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Вторая цифра трёхзначного числа - " + SecondDigit(n));