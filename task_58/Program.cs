// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

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

int n = 5; //new Random().Next(1, 10);
int m = 5; //new Random().Next(1, 10);

int[,] array = new int[n, m];

Console.WriteLine();
FillArray(array);
PrintArray(array);

if (n == m)
{
    for (int i = 0; i < array.GetLength(1); i++)

        for (int j = 0; j < i; j++)
        {
            int num = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = num;
        }
}
else
{
    Console.WriteLine("Поменять местами строки и столбцы нельзя. Матрица не квадратная");
}
Console.WriteLine();
PrintArray(array);