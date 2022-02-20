// Задать массив из 8 элементов и вывести их на экран

// Решение через создание и вывод случайного массива

void PrintArray(int[] array)
{
    int count = array.Length;
    int index = 0;
    while (index < count)
    {
        array[index] = new Random().Next(0, 10);
        Console.Write($"{array[index]} ");
        index++;
    }
}
int[] newAarray = new int[8];
Console.WriteLine($"Случайный массив из 8 элементов: ");
PrintArray(newAarray);
Console.WriteLine();

// Решение через ввод элементов вручную

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     for (index = 0; index < length; index++)
//     {
//         Console.WriteLine("Задайте число: ");
//         collection[index] = int.Parse(Console.ReadLine());
//     }
// }

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     int index = 0;
//     for (index = 0; index < count; index++)
//     {
//         Console.Write($"{array[index]} ");
//     }
// }

// int[] collection = new int[8];

// Console.WriteLine("Начинаем поочередный ввод 8-ми элементов массива.");
// FillArray(collection);
// Console.WriteLine();
// PrintArray(collection);
// Console.WriteLine();