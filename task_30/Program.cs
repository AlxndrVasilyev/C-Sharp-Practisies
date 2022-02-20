// Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Задайте целое число N");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Список кубов чисел от 1 до {N}, заканчивающихся на чётную цифру:");
for (int i = 2; i <= N; i++)
{
    if ((i * i * i) % 2 == 0)
        Console.WriteLine($"{i} ˆ 3 = {i * i * i}");
}

// Если учесть, что чётным куб может быть только от чётного числа,
// то можно и без проверки на чётность, сразу увеличивать i на 2

// Console.WriteLine("Задайте целое число N");
// int N = int.Parse(Console.ReadLine());
// Console.WriteLine($"Список кубов чисел от 1 до {N}, заканчивающихся на чётную цифру:");
// for (int i = 2; i <= N; i = i + 2)
// {
//     Console.WriteLine($"{i} ˆ 3 = {i * i * i}");
// }