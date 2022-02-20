// Написать программу для замены элементов массива на противоположные.

// метод заполнения массива
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    for (index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(0, 10);
    }
}

// метод печати массива

void PrintArray(int[] array)
{
    int count = array.Length;
    int index = 0;
    for (index = 0; index < count; index++)
    {
        Console.Write($"{array[index]} ");
    }
}

// метод замены элементов массива на противоположные

void OppositeArray(int[] array)
{
    int count = array.Length;
    int index = 0;
    for (index = 0; index < count; index++)
    {
        array[index] = array[index] * -1;
        Console.Write($"{array[index]} ");
    }
}

int[] opposite = new int[8];

FillArray(opposite);
PrintArray(opposite);
Console.WriteLine();
OppositeArray(opposite);
Console.WriteLine();