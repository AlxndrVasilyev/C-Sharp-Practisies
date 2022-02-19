// Программа проверяет пятизначное число на палиндромом.

Console.WriteLine("Введите пятизначное число");
string num = Console.ReadLine();
int length = num.Length;
if (length != 5)
    Console.WriteLine("Вы ввели не пятизначное число. Перезапустите программу");
else if (num[0] == num[4] && num[1] == num[3])
    Console.WriteLine($"Число {num} - палиндром");
else
    Console.WriteLine($"Число {num} - не палиндром");

// или математический вариант 

// int num = 63136; //new Random().Next(10000,99999);
// if (num / 10000 == num % 10 && num / 1000 % 10 == num % 100 / 10)
//     Console.WriteLine($"Число {num} - палиндром");
// else
//     Console.WriteLine($"Число {num} - не палиндром");