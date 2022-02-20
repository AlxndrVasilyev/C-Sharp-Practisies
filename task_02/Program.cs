// Даны два числа. Показать большее и меньшее число
Console.WriteLine("Введите первое число: ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n2 = int.Parse(Console.ReadLine());

if (n1 > n2) 
 {
    Console.WriteLine(n1 + " - большее число," + n2 + " - меньшее число");
 }
 else if (n2 > n1)
 {
    Console.WriteLine(n2 + " - большее число," + n1 + " - меньшее число");
 }
 else
 {
    Console.WriteLine("Числа равны");
 }