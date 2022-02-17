// Показать числа Фибоначчи

int a=1;
int b=1;
int count=10;
for (int i = 0; i < count; i++)
{
    Console.Write($"{a}, {b}, ");
    a=a+b;
    b=b+a;
}

// ниже альтернатива 

// int num = 10;
// int f1 = 1;
// int f2 = 1;
// int result;
// for (int i = 0; i < num; i++)
// {
//     result = f1 + f2;
//     Console.Write(result + " ");
//     f1 = f2;
//     f2 = result;
// }