// Задать массив из 8 элементов и вывести их на экран

void PrintArray(int[] col)
{
    int count = col.Length;
    int index = 0;
    while (index < count)
    {
        col[index] = new Random().Next(0, 10);
        Console.Write($"{col[index]} ");
        index++;
    }
}
int[] col = new int[8];
Console.WriteLine ($"Случайный массив из 8 элементов: ");
PrintArray(col);
Console.WriteLine();
