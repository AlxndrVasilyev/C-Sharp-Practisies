// Показать последнюю цифру трёхзначного числа

// Первый способ обычный

// Console.WriteLine("Введите трёхзначное число: ");
// int n = int.Parse(Console.ReadLine());
// int lastNumber = -1;
// lastNumber = n%10;
// Console.WriteLine("Последняя цифра трёхзначного числа - " + lastNumber);


// теперь с помощью функции(метода)

int LastDigit(int Number)
{
    return Number % 10;
}
Console.WriteLine("Введите трёхзначное число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Последняя цифра трёхзначного числа - " + LastDigit(n));