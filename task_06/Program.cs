// Выяснить является ли число чётным
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
if (a%2 == 0)
{
    Console.WriteLine("Это число чётное");
} 
else
{
    Console.WriteLine("Это число нечётное");
}