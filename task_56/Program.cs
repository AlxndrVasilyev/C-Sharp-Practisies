// Написать программу, которая обменивает элементы первой строки и последней строки

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]}");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 100); // заполняем числами [0,100)
        }
    }
}


int[,] array = new int[3, 5];
FillArray(array);
PrintArray(array);
int k=0;
for (int i = 0; i < array.GetLength(1); i++)
{
    int num = array[0, i];
    array[0, i] = array[array.GetLength(0) - 1, i];
    array[array.GetLength(0) - 1, i] = num;
}
Console.WriteLine();
PrintArray(array);