// Показать двумерный массив размером m×n заполненный целыми числами

int m=new Random().Next(1,10);
int n=new Random().Next(1,10);
int[,] array=new int[m,n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j]=new Random().Next();
        Console.Write(array[i,j]+" ");
    }
    Console.WriteLine();
}