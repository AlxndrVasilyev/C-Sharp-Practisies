// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int n = new Random().Next(1, 10);
int k = new Random().Next(1, 10);
int[,] array = new int[n, k];

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
    }
}
PrintArray(array);
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i = i + 2)
{
    for (int j = 0; j < array.GetLength(1); j = j + 2)
    {
        array[i, j] = array[i, j] * array[i, j];
    }
}
PrintArray(array);

// int n = new Random().Next(1, 10);
// int k = new Random().Next(1, 10);
// int[,] array = new int[n, k];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(0, 10);
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (i % 2 == 0 && j % 2 == 0) array[i, j] = array[i, j] * array[i, j];
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }








// // ещё одна альтернатива 

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($" {matr[i, j]}");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 100); // заполняем числами [0,100)
//         }
//     }
// }

// Console.WriteLine("Введите количество строк");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = int.Parse(Console.ReadLine());
// int[,] array = new int[m, n];
// FillArray(array);
// PrintArray(array);
// for (int i = 0; i < array.GetLength(0); i+=2)
// {
//     for (int j = 0; j < array.GetLength(1); j+=2)
//     {
//         array[i, j] = array[i, j] *  array[i, j];
//     }
// }
// Console.WriteLine();
// PrintArray(array);