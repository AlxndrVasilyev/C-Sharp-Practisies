// Найти сумму чисел одномерного массива стоящих на нечетной позиции

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    for (index = 0; index < length; index++)
    {
        array[index] = new Random().Next(0, 10);
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

void OddIndexSum(int[] array)
{
    int count = array.Length;
    int index = 0;
    int sumOdd = 0;
    for (index = 0; index < count; index = index + 2)
    {
        sumOdd = sumOdd + array[index + 1];
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма чисел под нечётным индеском в массиве = {sumOdd}");
}

int[] coll = new int[8];

Console.WriteLine();
FillArray(coll);
PrintArray(coll);
Console.WriteLine();
OddIndexSum(coll);
Console.WriteLine();