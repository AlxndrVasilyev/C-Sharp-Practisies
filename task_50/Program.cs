// В двумерном массиве n×k заменить четные элементы на противоположные

int n = new Random().Next(4, 6);
int k = new Random().Next(4, 6);
int[,] array = new int[n, k];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] % 2 == 0) array[i, j] = array[i, j] * (-1);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}