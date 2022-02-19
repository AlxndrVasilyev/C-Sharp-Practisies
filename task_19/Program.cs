// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int x = new Random().Next(-99, 99);
Console.WriteLine(x);
int y = new Random().Next(-99, 99);
Console.WriteLine(y);

if (x == 0 || y == 0)
    Console.WriteLine($" Если 'x' или 'y' равны нулю, принадлежность плоскости невозможно определить. Перезапустите программу");
else if (x > 0 && y > 0)
    Console.WriteLine($"Точка с координатами {x} и {y} в 1-ой четверти");
else if (x > 0 && y < 0)
    Console.WriteLine($"Точка с координатами {x} и {y} в 2-ой четверти");
else if (x < 0 && y < 0)
    Console.WriteLine($"Точка с координатами {x} и {y} в 3-ей четверти");
else
    Console.WriteLine($"Точка с координатами {x} и {y} в 4-ой четверти");
