// Определить количество цифр в числе

Console.WriteLine("Введите любое целое число");
int num = int.Parse(Console.ReadLine());
int j = 1;
for (int i = 0; i < num; i++)
{
    num = num/10;
    j++;
}
Console.WriteLine($"В числе содержится {j} цифр");

// ниже через число символов в строке

// Console.WriteLine("Введите любое целое число");
// string num = Console.ReadLine();  
// int length = num.Length;
// Console.WriteLine($"Количество цифр в числе {num} равно {length}");