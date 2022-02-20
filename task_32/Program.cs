// 

void PrintArray(int[] array)
{
    int count = array.Length;
    int index = 0;
    while (index < count)
    {
        array[index] = new Random().Next(0, 2);
        Console.Write($"{array[index]} ");
        index++;
    }
}
int[] newAarray = new int[8];
Console.WriteLine($"Массив из 8 элементов заполненный случайными нулями и единицами: ");
PrintArray(newAarray);
Console.WriteLine();