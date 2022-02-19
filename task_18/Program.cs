// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

// Выраженние истинно только при следующих вводных bool:

bool X = false;
bool Y = false;

if (!X | !Y == !X && !Y)
    Console.WriteLine($"Yes, it's true for X = {X} and Y = {Y}");
else
    Console.WriteLine("Nope, it's false");