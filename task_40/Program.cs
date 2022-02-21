// // В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

void FillArray(double[] array)
{
    int length = array.Length;
    int index = 0;
    for (index = 0; index < length; index++)
    {
        array[index] = new Random().Next(-100, 100);
    }
}

void PrintArray(double[] array)
{
    int count = array.Length;
    int index = 0;
    for (index = 0; index < count; index++)
    {
        Console.Write($"{array[index]} ");
    }
}

void MaxMinDiff(double[] array)
{
    int length = array.Length;
    int index = 0;
    double max = 0;
    double min = 0;
    double tmp = 0;

    for (index = 0; index < length; index++)
    {
        if (array[index] > max) max = array[index];
        else if (array[index] < min) min = array[index];
        else if (tmp < min) min = tmp;
        else tmp = array[index];
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементом = {max - min}");
}

double[] array = new double[8];

FillArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
MaxMinDiff(array);
Console.WriteLine();