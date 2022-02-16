// Удалить вторую цифру трёхзначного числа

int firstDigit(int Number)
{
     int firstDigit = Number / 100;
     return firstDigit;
}
int thirdDigit(int Number)
{
     int thirdDigit = Number % 10;
     //return (firstDigit & thirdDigit);
     return thirdDigit;
}
Console.WriteLine("Введите трёхзначное число: ");
int n = int.Parse(Console.ReadLine());
Console.Write(firstDigit(n));
Console.WriteLine(thirdDigit(n));