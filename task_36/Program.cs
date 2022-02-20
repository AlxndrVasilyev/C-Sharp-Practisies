// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных/четных чисел

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    for (index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(100, 999);
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int index = 0;
    for (index = 0; index < count; index++)
    {
        Console.Write($"{array[index]} ");
    }
}

void NumEvenOdd(int[] array)
{
    int count = array.Length;
    int index = 0;
    int numEven = 0;
    int numOdd = 0;

    for (index = 0; index < count; index++)
    {
        if (array[index] % 2 == 0)
        {
            numEven++;
        }
        else
        {
            numOdd++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Количество чётных элементов в массиве = {numEven}");
    Console.WriteLine();
    Console.WriteLine($"Количество нечётных элементов в массиве = {numOdd}");
}

int[] evenOdd = new int[8];

Console.WriteLine();
FillArray(evenOdd);
PrintArray(evenOdd);
Console.WriteLine();
NumEvenOdd(evenOdd);
Console.WriteLine();