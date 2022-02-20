// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива/

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    for (index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(0, 10);
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

void SumPlusMinus(int[] array)
{
    int count = array.Length;
    int index = 0;
    int sumPlus = 0;
    int sumMinus = 0;

    for (index = 0; index < count; index++)
    {
        if (array[index] >= 0)
        {
            sumPlus = sumPlus + array[index];
        }
        else
        {
            sumMinus = sumMinus + array[index];
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма всех положительных элементов массива = {sumPlus}");
    Console.WriteLine();
    Console.WriteLine($"Сумма всех отрицательных элементов массива = {sumMinus}");
}

int[] dozenArray = new int[12];

Console.WriteLine();
FillArray(dozenArray);
PrintArray(dozenArray);
Console.WriteLine();
SumPlusMinus(dozenArray);
Console.WriteLine();