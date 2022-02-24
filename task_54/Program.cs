// В матрице чисел найти сумму элементов главной диагонали

// int n = new Random().Next(5, 10);
// int k = new Random().Next(5, 10);
// int[,] array = new int[n, k];
// int a = 0;

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(0, 10);
//     }
// }
// PrintArray(array);
// Console.WriteLine();

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (i == j) a = a + array[i, j];
//     }
// }
// Console.WriteLine(a);



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
            matr[i, j] = new Random().Next(1, 10); // заполняем числами от 0 до 9
        }
    }
}

Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);

int sum = 0;
int size = 0;

if (m >= n) size = n;
else size = m;
for (int i = 0; i < size; i++)
    {
        sum += array[i, i];
    }
Console.WriteLine(sum);