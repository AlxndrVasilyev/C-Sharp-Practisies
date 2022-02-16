// Дано число обозначающее день недели. Выяснить является номер дня недели выходным.
Console.WriteLine("Выберите номер дня недели - от 1 до 7: ");
int n = int.Parse(Console.ReadLine());
if(n > 5) Console.WriteLine("Это выходной");
else Console.WriteLine("Это будний день");