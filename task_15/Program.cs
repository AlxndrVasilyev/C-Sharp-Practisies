// Дано число. Проверить кратно ли оно 7 и 23
Console.WriteLine("Задайте число: ");
int n = int.Parse(Console.ReadLine());
if (n%7 == 0 && n%23 == 0) Console.WriteLine(true);
else Console.WriteLine (false);

// switch (n % 7)
// {
//     case 0 when n % 23 == 0:
//         Console.WriteLine(true);
//         break;
//     default:
//         Console.WriteLine(false);
//         break;
// }