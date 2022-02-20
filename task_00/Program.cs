// Вывести квадрат числа

Console.WriteLine("Введите число: ");

// int n = new Random().Next(1,10); - генератор случайных чисел от 1 до 9

int n = int.Parse(Console.ReadLine());
Console.WriteLine("n = " + n); // - вывод числа из генератора
Console.WriteLine("nˆ2 = " + n*n);