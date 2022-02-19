// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Задайте номер четверти от 1 до 4");
int num = int.Parse(Console.ReadLine());

if (num > 4)
    Console.WriteLine("Ошибка. Задан неправильный номер");
else if (num == 1)
    Console.WriteLine($"Диапазон возможных значений координат (x > 0) и (y > 0)");
else if (num == 2)
    Console.WriteLine($"Диапазон возможных значений координат (x > 0) и (y < 0)");
else if (num == 3)
    Console.WriteLine($"Диапазон возможных значений координат (x < 0) и (y < 0)");
else
    Console.WriteLine($"Диапазон возможных значений координат (x < 0) и (y > 0)");