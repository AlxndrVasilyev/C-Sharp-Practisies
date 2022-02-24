// Составить частотный словарь элементов двумерного массива

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
            matr[i, j] = new Random().Next(1, 10); // заполняем числами [0,10)
        }
    }
}

void frequencyOutputArray(int[,] arr, int[,] arrOutput)
{
    int index = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int count = 0;
            for (int m = i; m < arr.GetLength(0); m++)
            {
                for (int n = 0; n < arr.GetLength(1); n++)
                {
                    if (arr[m, n] == arr[i, j]) count++;
                }
            }
            for (int d = 0; d <= index; d++)
            {
                if (d == index)
                {
                    arrOutput[index, 0] = arr[i, j];
                    arrOutput[index, 1] = count;
                    index++;
                    break;
                }
                if (arr[i, j] == arrOutput[d, 0] && arrOutput[d, 1] > 0) break;
            }

        }
    }
}

void sortArray(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        int min = arr[j, 0];
        for (int n = j + 1; n < arr.GetLength(0); n++)
        {
            if (arr[n, 0] < min && arr[n, 1] > 0)
            {
                arr[j, 0] = arr[n, 0];
                arr[n, 0] = min;
                min = arr[j, 1];
                arr[j, 1] = arr[n, 1];
                arr[n, 1] = min;
                min = arr[j, 0];
            }
        }
    }
}

int[,] array = new int[3, 3];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int[,] frequencyAnalysArrays = new int[array.GetLength(0) * array.GetLength(1), 2];

frequencyOutputArray(array, frequencyAnalysArrays);
sortArray(frequencyAnalysArrays);
for (int i = 0; i < frequencyAnalysArrays.GetLength(0) && frequencyAnalysArrays[i, 1] > 0; i++)
    Console.WriteLine($"{frequencyAnalysArrays[i, 0]} встречается {frequencyAnalysArrays[i, 1]} раз");